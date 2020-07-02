using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    private bool allowMovement;
    UnityEngine.Object [] selectedObjects;
    ObjectCommunication[] objects;
    // Start is called before the first frame update
    void Start()
    {

        allowMovement = true;
        objects = GetComponentsInChildren<ObjectCommunication>();
    }

    private void Update()
    {
        
    }
    public void MessageButtonPressed() {


        if (allowMovement)
        {
            
            for (int i = 0; i < objects.Length; i++)
                objects[i].StartMoving();
            allowMovement = false;
        }
        else {
            for (int i = 0; i < objects.Length; i++)
                objects[i].StopMoving();
            allowMovement = true;
        }

    }
}
