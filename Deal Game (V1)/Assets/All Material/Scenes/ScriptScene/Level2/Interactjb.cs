using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactjb : MonoBehaviour
{
    public BrigeSetting brigeSetting;

    public GameObject interactjbButton;
    
    void Start()
    {
        interactjbButton.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactjbButton.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactjbButton.SetActive(false);
        }
    }
}
