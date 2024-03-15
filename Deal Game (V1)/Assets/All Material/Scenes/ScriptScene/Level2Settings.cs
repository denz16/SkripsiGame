using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2Settings : MonoBehaviour
{
    public GameObject SelesaiMisiButton;
    public GameObject TerkumpulPanel;
    public GameObject SemangkaPanel;
    public GameObject Level2Panel;
    public GameObject nextLevel2Button;
    public GameObject HUDSoal2;
    public GameObject Misi2ComplitePanel;
    public GameObject MisiSelesai2Panel;
    public GameObject HUDLevel3;
    public GameObject HUDSoal3;
    public GameObject Level3Panel;
    public GameObject Next3Button;
    public GameObject MisiSelesai3Panel;
    public GameObject Misi3ComplitePanel;
    public GameObject HUDLevel4;
    public GameObject Spart2;
    public GameObject HUDSoal4;
    public GameObject MisiSelesai4Panel;
    public GameObject Misi4ComplitePanel;
    public AudioSource SoundSlider;

    void Start()
    {
        SelesaiMisiButton.SetActive(false);
    }
    
   public void selesaiButton()
    {
        Time.timeScale = 0;
        SoundSlider.Pause();
        TerkumpulPanel.SetActive(false);
        SemangkaPanel.SetActive(false);
        
        Level2Panel.SetActive(true);
        nextLevel2Button.SetActive(true);
    }

    public void NextLevel2Button()
    {
        nextLevel2Button.SetActive(false);
        Level2Panel.SetActive(false);
        HUDSoal2.SetActive(true);
    }

    public void Level3Button()
    {
        Misi2ComplitePanel.SetActive(false);
        MisiSelesai2Panel.SetActive(true);
    }

    public void nextLevel3Button()
    {
        MisiSelesai2Panel.SetActive(false);
        HUDLevel3.SetActive(true);
        SoundSlider.Play();
        Time.timeScale = 1;
    }

    // public void nextQButton()
    // {
    //     Time.timeScale = 0;
    //     SoundSlider.Pause();
    //     HUDLevel4.SetActive(true);
    // }

    public void nextQ2Button()
    {
        Level3Panel.SetActive(false);
        Next3Button.SetActive(false);
        HUDSoal3.SetActive(true);
    }

    public void nextQ3Button()
    {
        Misi3ComplitePanel.SetActive(false);
        MisiSelesai3Panel.SetActive(true);
        HUDLevel4.SetActive(true);
    }

    public void nextQ4Button()
    {
        Spart2.SetActive(true);
        MisiSelesai3Panel.SetActive(false);
        SoundSlider.Play();
        Time.timeScale = 1;
    }

    public void nextQ5Button()
    {
        Misi4ComplitePanel.SetActive(false);
        MisiSelesai4Panel.SetActive(true);
    }

    public void EndButton()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefsManager.instance.SetLastScene("Main");
    }
}
