using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ObjectCommunication : MonoBehaviour
{
    private bool  startInteraction;

    Animator animator;

   
    // Start is called before the first frame update
    void Start()
    {

        startInteraction = false;
        animator = GetComponent<Animator>();
        animator.Play("Obj_Idle");

    }

    // Update is called once per frame
    void Update()
    {
        if (startInteraction)
        {
            animator.Play("Obj_Speak");

        }
        else {
            animator.Play("Obj_Idle");
        }
    }

    public void StartMoving() {
        startInteraction = true;
        
    }
    public void StopMoving() {
        startInteraction = false;
    }

    
}
