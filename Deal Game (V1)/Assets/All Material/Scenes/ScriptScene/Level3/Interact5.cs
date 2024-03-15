using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interact5 : MonoBehaviour
{
    public Dialogue dialogue;

    public GameObject interact3View;
    public GameObject dialogue3View;
    public GameObject interact5Button;
    public GameObject BackGroundView3;
    public GameObject Level3Panel;
    
    public AudioSource SoundSlider;

    public TextMeshProUGUI dialogue3Text;
    
    public NPC5Settings npc5Settings;
    
    Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        interact3View.SetActive(false);
        dialogue3View.SetActive(false);
        interact5Button.SetActive(false);
        BackGroundView3.SetActive(false);

        sentences = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {
        if (npc5Settings.isInteract1)
        {
            interact5Button.SetActive(false);
            interact3View.SetActive(false);

            dialogue3View.SetActive(true);
            BackGroundView3.SetActive(true);
        }
        else
        {
            dialogue3View.SetActive(false);
            BackGroundView3.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact3View.SetActive(true);
            interact5Button.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact3View.SetActive(false);
            interact5Button.SetActive(false);

            npc5Settings.isInteract1 = false;
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }


    IEnumerator TypeSentence(string sentence)
    {
        dialogue3Text.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogue3Text.text += letter;
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(1.5f);

        DisplayNextSentence();
    }

    public void EndDialogue()
    {
        npc5Settings.isInteract1 = false;
        Time.timeScale = 0;
        SoundSlider.Pause();
        Level3Panel.SetActive(true);
    }

    public void DialogueTrigger()
    {
        StartDialogue(dialogue);
        npc5Settings.Interact1();
    }
  
}
