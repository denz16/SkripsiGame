using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC5Settings : MonoBehaviour
{
    PlayerController playerController;

    Animator animator;

    [HideInInspector]
    public bool isInteract1 = false;

    [HideInInspector]
    public bool isIdle1 = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        playerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isInteract1)
        {
            animator.SetBool("IsTalk1", false);
            isIdle1 = true;
        }
        else
            {
                
                Vector3 direction = (playerController.transform.position - transform.position).normalized;
                Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
            }
    }
    public void Interact1()
    {
        isInteract1 = true;
        animator.SetBool("IsTalk1", true);
    }
}
