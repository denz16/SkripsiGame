using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD2SoalScript : MonoBehaviour
{
    public Text skor2Text;
    public GameObject Misi2ComplitePanel;
    public GameObject SelesaiMisi2Button;
    public GameObject Misi2UnComplitePanel;
    public GameObject BackLevel2Button;
    public GameObject HUDSoal2;
    
    [System.Serializable]
    public class Soal
    {
        [TextArea(3, 10)]
        public string soal2Text;
        public string[] jawaban2;
        public int jawaban2BenarNo;
        public Sprite gambar2Soal;
    }

    public Button[] jawaban2Button;

    public Soal[] soal2;

    public Text soal2TextUI;
    public Image gambar2SoalUI;

    private int soal2Index = 0;


    void Start()
    {
        
        for (int i = 0; i < jawaban2Button.Length; i++)
        {
            int j = i;
            jawaban2Button[i].onClick.AddListener(delegate {JawabanOnClick(j);});
        }

        SetSoal2();
        PlayerPrefs.SetInt("Skor", 0);
        skor2Text.text = "Skor: " + PlayerPrefs.GetInt("Skor", 0); 
    }


    public void backLevel2Button()
    {
        PlayerPrefs.DeleteAll();
        Misi2UnComplitePanel.SetActive(false);
        BackLevel2Button.SetActive(false);
        Time.timeScale = 1;
        PlayerPrefsManager.instance.SetLastScene(PlayerPrefsManager.instance.GetLastScene2());
    }

    void SetSoal2()
    {
        soal2TextUI.text = soal2[soal2Index].soal2Text;
        gambar2SoalUI.sprite = soal2[soal2Index].gambar2Soal;

        for (int i = 0; i < jawaban2Button.Length; i++)
        {
            jawaban2Button[i].GetComponentInChildren<Text>().text = soal2[soal2Index].jawaban2[i];
        }
    }

    public void JawabanOnClick(int jawaban2Index)
    {
        if (jawaban2Index == soal2[soal2Index].jawaban2BenarNo-1)
        {
            Debug.Log("Jawaban benar!");
            int tambahSkor = PlayerPrefs.GetInt("Skor") + 10;
            PlayerPrefs.SetInt("Skor", tambahSkor);
        }
        else
        {
            Debug.Log("Jawaban salah!");
        }

        skor2Text.text = "Skor :" + PlayerPrefs.GetInt("Skor", 0); 

        soal2Index++;

        if (soal2Index < soal2.Length)
        {
            SetSoal2();
        }
        else
        {
            if(PlayerPrefs.GetInt("Skor") >= 20)
            {
                HUDSoal2.SetActive(false);
                Misi2ComplitePanel.SetActive(true);
                SelesaiMisi2Button.SetActive(true);
            }
            else
            {
                HUDSoal2.SetActive(false);
                Misi2UnComplitePanel.SetActive(true);
                BackLevel2Button.SetActive(true);
            }
        }

        
    }
}
