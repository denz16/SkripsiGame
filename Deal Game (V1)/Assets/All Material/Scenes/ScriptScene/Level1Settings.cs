using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1Settings : MonoBehaviour
{
    public GameObject SelesaiMisiButton;
    public GameObject TerkumpulPanel;
    public GameObject kayuPanel;
    public GameObject HUDPJ1;
    public GameObject NPC1Scavenger;
    public GameObject NPC2;
    public GameObject nextLevel2Button;
    public GameObject Level2Box;


    void Start()
    {
        SelesaiMisiButton.SetActive(false);
    }
    
   public void selesaiButton()
    {
        TerkumpulPanel.SetActive(false);
        kayuPanel.SetActive(false);
        NPC1Scavenger.SetActive(false);
        Destroy(NPC1Scavenger);
        NPC2.SetActive(true);
        HUDPJ1.SetActive(true);
        Time.timeScale = 1;
    }

    public void NextLevel2Button()
    {
        HUDPJ1.SetActive(false);
        
        nextLevel2Button.SetActive(false);
        Level2Box.SetActive(true);
        Time.timeScale = 1;
    }

}
