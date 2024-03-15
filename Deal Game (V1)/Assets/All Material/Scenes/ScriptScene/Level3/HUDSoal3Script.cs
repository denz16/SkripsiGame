using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDSoal3Script : MonoBehaviour
{
    public Text skor3Text;

    public GameObject Misi3ComplitePanel;
    public GameObject SelesaiMisi3Button;
    public GameObject Misi3UnComplitePanel;
    public GameObject BackLevel3Button;
    public GameObject HUDSoal3;

    [System.Serializable]
    public class Soal
    {
        [TextArea(3, 10)]
        public string soal3Text;
        public string[] jawaban3;
        public int jawaban3BenarNo;
        // public Sprite gambar3Soal;
    }

    public Button[] jawaban3Button;

    public Soal[] soal3;

    public Text soal3TextUI;
    // public Image gambar3SoalUI;

    private int soal3Index = 0;


    void Start()
    {
        
        for (int i = 0; i < jawaban3Button.Length; i++)
        {
            int j = i;
            jawaban3Button[i].onClick.AddListener(delegate {JawabanOnClick(j);});
        }

        SetSoal3();
        PlayerPrefs.SetInt("Skor", 0);
        skor3Text.text = "Skor: " + PlayerPrefs.GetInt("Skor", 0); 
    }


    public void backLevel3Button()
    {
        PlayerPrefs.DeleteAll();
        Misi3UnComplitePanel.SetActive(false);
        BackLevel3Button.SetActive(false);
        Time.timeScale = 1;
        PlayerPrefsManager.instance.SetLastScene(PlayerPrefsManager.instance.GetLastScene2());
    }

    void SetSoal3()
    {
        soal3TextUI.text = soal3[soal3Index].soal3Text;
        // gambar3SoalUI.sprite = soal3[soal3Index].gambar3Soal;

        for (int i = 0; i < jawaban3Button.Length; i++)
        {
            jawaban3Button[i].GetComponentInChildren<Text>().text = soal3[soal3Index].jawaban3[i];
        }
    }

    public void JawabanOnClick(int jawaban3Index)
    {
        if (jawaban3Index == soal3[soal3Index].jawaban3BenarNo-1)
        {
            Debug.Log("Jawaban benar!");
            int tambahSkor = PlayerPrefs.GetInt("Skor") + 10;
            PlayerPrefs.SetInt("Skor", tambahSkor);
        }
        else
        {
            Debug.Log("Jawaban salah!");
        }

        skor3Text.text = "Skor :" + PlayerPrefs.GetInt("Skor", 0); 

        soal3Index++;

        if (soal3Index < soal3.Length)
        {
            SetSoal3();
        }
        else
        {
            if(PlayerPrefs.GetInt("Skor") >= 20)
            {
                HUDSoal3.SetActive(false);
                Misi3ComplitePanel.SetActive(true);
                SelesaiMisi3Button.SetActive(true);
            }
            else
            {
                HUDSoal3.SetActive(false);
                Misi3UnComplitePanel.SetActive(true);
                BackLevel3Button.SetActive(true);
            }
        }

        
    }
}
