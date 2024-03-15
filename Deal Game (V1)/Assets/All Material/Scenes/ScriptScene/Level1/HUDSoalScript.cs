using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDSoalScript : MonoBehaviour
{
    public Text skorText;
    public GameObject Misi1ComplitePanel;
    public GameObject SelesaiMisiButton;
    public GameObject MisiUnComplitePanel;
    public GameObject BackLevelButton;
    
    [System.Serializable]
    public class Soal
    {
        [TextArea(3, 10)]
        public string soalText;
        public string[] jawaban;
        public int jawabanBenarNo;
        public Sprite gambarSoal;
    }

    public Button[] jawabanButton;

    public Soal[] soal;

    public Text soalTextUI;
    public Image gambarSoalUI;

    private int soalIndex = 0;


    void Start()
    {
        
        for (int i = 0; i < jawabanButton.Length; i++)
        {
            int j = i;
            jawabanButton[i].onClick.AddListener(delegate {JawabanOnClick(j);});
        }

        SetSoal();
        PlayerPrefs.SetInt("Skor", 0);
        skorText.text = "Skor: " + PlayerPrefs.GetInt("Skor", 0); 
    }


    public void backLevelButton()
    {
        PlayerPrefs.DeleteAll();
        MisiUnComplitePanel.SetActive(false);
        BackLevelButton.SetActive(false);
        Time.timeScale = 1;
        PlayerPrefsManager.instance.SetLastScene(PlayerPrefsManager.instance.GetLastScene());
    }

    void SetSoal()
    {
        soalTextUI.text = soal[soalIndex].soalText;
        gambarSoalUI.sprite = soal[soalIndex].gambarSoal;

        for (int i = 0; i < jawabanButton.Length; i++)
        {
            jawabanButton[i].GetComponentInChildren<Text>().text = soal[soalIndex].jawaban[i];
        }
    }

    public void JawabanOnClick(int jawabanIndex)
    {
        if (jawabanIndex == soal[soalIndex].jawabanBenarNo-1)
        {
            Debug.Log("Jawaban benar!");
            int tambahSkor = PlayerPrefs.GetInt("Skor") + 10;
            PlayerPrefs.SetInt("Skor", tambahSkor);
        }
        else
        {
            Debug.Log("Jawaban salah!");
        }

        skorText.text = "Skor :" + PlayerPrefs.GetInt("Skor", 0); 

        soalIndex++;

        if (soalIndex < soal.Length)
        {
            SetSoal();
        }
        else
        {
            if(PlayerPrefs.GetInt("Skor") >= 20)
            {
                Misi1ComplitePanel.SetActive(true);
                SelesaiMisiButton.SetActive(true);
            }
            else
            {
                MisiUnComplitePanel.SetActive(true);
                BackLevelButton.SetActive(true);
            }
        }

        
    }
}
