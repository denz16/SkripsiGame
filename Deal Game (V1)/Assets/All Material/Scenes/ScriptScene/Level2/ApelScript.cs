using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApelScript : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider target)
    {
        if(target.gameObject.tag == "Player")
        {
            Score2Script.ApelS += 1;
            Destroy(gameObject);
        }
    }
}
