using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSettings : MonoBehaviour
{
    public GameObject settingsButton;
    public GameObject settingsPanel;

    public GameObject Quest;
    public GameObject DemoPanel;
    public GameObject PlayerDemoPanel;
    public GameObject Demo2Panel;
    public GameObject Back2demoButton;
    public GameObject nextpanelButton;
    public GameObject CreditsButton;
    public GameObject CreditsPanel;
    public GameObject BackCRButton;
    public GameObject TextPanel;

    public GameObject Stage;
    public GameObject level1Button;
    public GameObject level1Panel;
    public GameObject level2Button;
    public GameObject level2Panel;
    public GameObject level3Button;
    public GameObject level3Panel;
    public GameObject level4Button;
    public GameObject level4Panel;
    
    public GameObject Maps;
    public GameObject HouseButton;
    public GameObject HousePanel;
    public GameObject StoreButton;
    public GameObject StorePanel;
    public GameObject BeruangButton;
    public GameObject BeruangPanel;
    public GameObject SavanaButton;
    public GameObject SavanaPanel;
    public GameObject MulaiPlayerButton;
    public GameObject MulaiPlayerPanel;

    public void StartButton()
    {
        // PlayerPrefs.DeleteAll();
        if (PlayerPrefsManager.instance.GetLastScene() != "Main")
        {
            PlayerPrefsManager.instance.SetLastScene(PlayerPrefsManager.instance.GetLastScene());
        }
        else
        {
            PlayerPrefsManager.instance.SetLastScene("Home");
        }
        
    }

    public void QuestButton()
    {
        Quest.SetActive(true);
    }

    public void LevelButton()
    {
        Stage.SetActive(true);
    }

    public void MapsButton()
    {
        Maps.SetActive(true);
    }

    public void DemoButton()
    {
        DemoPanel.SetActive(true);
    }

    public void SettingsButton()
    {
        settingsButton.SetActive(false);

        settingsPanel.SetActive(true);
    }

    public void BackButtonSettings()
    {
        settingsButton.SetActive(true);

        settingsPanel.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void BackGame()
    {
        Quest.SetActive(false);
    }

    public void Level()
    {
        Stage.SetActive(true);
        Quest.SetActive(false);
    }

    public void Demo()
    {
        DemoPanel.SetActive(true);
        Quest.SetActive(false);
    }

    public void creditsButton()
    {
        CreditsPanel.SetActive(true);
        BackCRButton.SetActive(true);
        TextPanel.SetActive(false);
    }

    public void backCRButton()
    {
        TextPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        BackCRButton.SetActive(false);
    }

    public void GetMission()
    {
        PlayerPrefsManager.instance.SetLastScene("Home");
    }

    public void Level1()
    {
        level2Panel.SetActive(false);
        level3Panel.SetActive(false);
        level4Panel.SetActive(false);

        level2Button.SetActive(true);
        level3Button.SetActive(true);
        level4Button.SetActive(true);
        level1Button.SetActive(true);
        level1Panel.SetActive(true);
    }

    public void Level2()
    {
        level1Panel.SetActive(false);
        level3Panel.SetActive(false);
        level4Panel.SetActive(false);

        level2Button.SetActive(true);
        level3Button.SetActive(true);
        level4Button.SetActive(true);
        level1Button.SetActive(true);
        level2Button.SetActive(true);
        level2Panel.SetActive(true);
    }

    public void Level3()
    {
        level2Panel.SetActive(false);
        level1Panel.SetActive(false);
        level4Panel.SetActive(false);

        level2Button.SetActive(true);
        level3Button.SetActive(true);
        level4Button.SetActive(true);
        level1Button.SetActive(true);
        level3Button.SetActive(true);
        level3Panel.SetActive(true);
    }

    public void Level4()
    {
        level2Panel.SetActive(false);
        level3Panel.SetActive(false);
        level1Panel.SetActive(false);

        level2Button.SetActive(true);
        level3Button.SetActive(true);
        level4Button.SetActive(true);
        level1Button.SetActive(true);
        level4Button.SetActive(true);
        level4Panel.SetActive(true);
    }

    public void BackStageButton()
    {
        Stage.SetActive(false);
    }

    public void NextPanelButton()
    {
        Demo2Panel.SetActive(true);
        Back2demoButton.SetActive(true);
        
        PlayerDemoPanel.SetActive(false);
        nextpanelButton.SetActive(false);
    }

    public void back2DemoButton()
    {
        Back2demoButton.SetActive(false);
        Demo2Panel.SetActive(false);

        PlayerDemoPanel.SetActive(true);
        nextpanelButton.SetActive(true);
    }

    public void BackPlayButton()
    {
        DemoPanel.SetActive(false);
    }

     public void House()
    {
        
        StoreButton.SetActive(false);
        StorePanel.SetActive(false);
        BeruangButton.SetActive(false);
        BeruangPanel.SetActive(false);
        SavanaButton.SetActive(false);
        SavanaPanel.SetActive(false);
        MulaiPlayerButton.SetActive(false);
        MulaiPlayerPanel.SetActive(false);
        HouseButton.SetActive(false);

        HousePanel.SetActive(true);
    }

     public void Store()
    {
        
        StoreButton.SetActive(false);
        BeruangButton.SetActive(false);
        BeruangPanel.SetActive(false);
        SavanaButton.SetActive(false);
        SavanaPanel.SetActive(false);
        MulaiPlayerButton.SetActive(false);
        MulaiPlayerPanel.SetActive(false);
        HouseButton.SetActive(false);
        HousePanel.SetActive(false);

        StorePanel.SetActive(true);
    }

    public void Beruang()
    {
        
        StoreButton.SetActive(false);
        StorePanel.SetActive(false);
        BeruangButton.SetActive(false);
        SavanaButton.SetActive(false);
        SavanaPanel.SetActive(false);
        MulaiPlayerButton.SetActive(false);
        MulaiPlayerPanel.SetActive(false);
        HouseButton.SetActive(false);
        HousePanel.SetActive(false);

        BeruangPanel.SetActive(true);
    }

    public void Savana()
    {
        
        StoreButton.SetActive(false);
        StorePanel.SetActive(false);
        BeruangButton.SetActive(false);
        BeruangPanel.SetActive(false);
        SavanaButton.SetActive(false);
        MulaiPlayerButton.SetActive(false);
        MulaiPlayerPanel.SetActive(false);
        HouseButton.SetActive(false);
        HousePanel.SetActive(false);

        SavanaPanel.SetActive(true);
    }

    public void MulaiPlayer()
    {
        
        StoreButton.SetActive(false);
        StorePanel.SetActive(false);
        BeruangButton.SetActive(false);
        BeruangPanel.SetActive(false);
        SavanaButton.SetActive(false);
        SavanaPanel.SetActive(false);
        MulaiPlayerButton.SetActive(false);
        HouseButton.SetActive(false);
        HousePanel.SetActive(false);

        MulaiPlayerPanel.SetActive(true);
    }

    public void Back()
    {
        
        StorePanel.SetActive(false);
        BeruangPanel.SetActive(false);
        SavanaPanel.SetActive(false);
        MulaiPlayerPanel.SetActive(false);
        HousePanel.SetActive(false);

        StoreButton.SetActive(true);
        BeruangButton.SetActive(true);
        SavanaButton.SetActive(true);
        MulaiPlayerButton.SetActive(true);
        HouseButton.SetActive(true);
    }

    public void BackButton()
    {
        Maps.SetActive(false);
    }
        
}
