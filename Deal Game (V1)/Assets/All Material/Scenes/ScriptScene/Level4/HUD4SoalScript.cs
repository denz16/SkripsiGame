using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD4SoalScript : MonoBehaviour
{
    public Text skor4Text;

    public GameObject Misi4ComplitePanel;
    public GameObject SelesaiMisi4Button;
    public GameObject Misi4UnComplitePanel;
    public GameObject BackLevel4Button;
    public GameObject HUDSoal4;

    [System.Serializable]
    public class Soal
    {
        [TextArea(3, 10)]
        public string soal4Text;
        public string[] jawaban4;
        public int jawaban4BenarNo;
        // public Sprite gambar4Soal;
    }

    public Button[] jawaban4Button;

    public Soal[] soal4;

    public Text soal4TextUI;
    // public Image gambar4SoalUI;

    private int soal4Index = 0;


    void Start()
    {
        
        for (int i = 0; i < jawaban4Button.Length; i++)
        {
            int j = i;
            jawaban4Button[i].onClick.AddListener(delegate {JawabanOnClick(j);});
        }

        SetSoal4();
        PlayerPrefs.SetInt("Skor", 0);
        skor4Text.text = "Skor: " + PlayerPrefs.GetInt("Skor", 0); 
    }


    public void backLevel4Button()
    {
        PlayerPrefs.DeleteAll();
        Misi4UnComplitePanel.SetActive(false);
        BackLevel4Button.SetActive(false);
        Time.timeScale = 1;
        PlayerPrefsManager.instance.SetLastScene(PlayerPrefsManager.instance.GetLastScene2());
    }

    void SetSoal4()
    {
        soal4TextUI.text = soal4[soal4Index].soal4Text;
        // gambar4SoalUI.sprite = soal4[soal4Index].gambar4Soal;

        for (int i = 0; i < jawaban4Button.Length; i++)
        {
            jawaban4Button[i].GetComponentInChildren<Text>().text = soal4[soal4Index].jawaban4[i];
        }
    }

    public void JawabanOnClick(int jawaban4Index)
    {
        if (jawaban4Index == soal4[soal4Index].jawaban4BenarNo-1)
        {
            Debug.Log("Jawaban benar!");
            int tambahSkor = PlayerPrefs.GetInt("Skor") + 10;
            PlayerPrefs.SetInt("Skor", tambahSkor);
        }
        else
        {
            Debug.Log("Jawaban salah!");
        }

        skor4Text.text = "Skor :" + PlayerPrefs.GetInt("Skor", 0); 

        soal4Index++;

        if (soal4Index < soal4.Length)
        {
            SetSoal4();
        }
        else
        {
            if(PlayerPrefs.GetInt("Skor") >= 20)
            {
                HUDSoal4.SetActive(false);
                Misi4ComplitePanel.SetActive(true);
                SelesaiMisi4Button.SetActive(true);
            }
            else
            {
                HUDSoal4.SetActive(false);
                Misi4UnComplitePanel.SetActive(true);
                BackLevel4Button.SetActive(true);
            }
        }

        
    }
}
