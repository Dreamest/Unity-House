using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    private Animator animator;
    private bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isOpen = false;
        Debug.Log("Start");

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Y");
        if (other.CompareTag("MainCamera"))
        {
            animator.SetTrigger("Open");
            isOpen = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("X");
        if (isOpen)
        {
            animator.SetTrigger("Close");
            isOpen = false;
        }
    }
}
