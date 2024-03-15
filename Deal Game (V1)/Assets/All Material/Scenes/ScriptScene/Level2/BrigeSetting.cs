using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrigeSetting : MonoBehaviour
{
    PlayerController playerController;

    public GameObject interactjbButton;
    public GameObject Spart1;
    public GameObject HUDLevel2;
    public GameObject interactjbView;
    
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    public void intJBButton()
    {
        interactjbButton.SetActive(false);
        interactjbView.SetActive(false);
        HUDLevel2.SetActive(true);
        Spart1.SetActive(true);
    }
}
