using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2Script : MonoBehaviour
{
    Text text;
    public static int SemangkaA = 0;
    public static int ApelS = 0;
    public GameObject TerkumpulPanel;
    public GameObject SelesaiMisiButton;

    void Start()
    {
        text = GetComponent<Text>();
        TerkumpulPanel.SetActive(false);
    }

    void Update()
    {
       text.text = "Semangka Terkumpul :" + SemangkaA.ToString() + " Apel Terkumpul :" + ApelS.ToString();

       if(SemangkaA > 8 && ApelS > 3)
       {
            Time.timeScale = 0;
            TerkumpulPanel.SetActive(true);
            SelesaiMisiButton.SetActive(true);
       }
    }
}
