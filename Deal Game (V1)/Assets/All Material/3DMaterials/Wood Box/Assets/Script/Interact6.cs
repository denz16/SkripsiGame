using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact6 : MonoBehaviour
{
    public GameObject interact6View;
    public GameObject interact6Button;
    
    public Box6Settings box6Settings;
    
    // Start is called before the first frame update
    void Start()
    {
        interact6View.SetActive(false);
        interact6Button.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact6View.SetActive(true);
            interact6Button.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interact6View.SetActive(false);
            interact6Button.SetActive(false);
        }
    }
}
