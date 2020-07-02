using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private ObjectCommunication[] toys;
    void Start()
    {
        toys = GetComponentsInChildren<ObjectCommunication>();
    }
 
    public void MessageButtonIsPressed() {
        foreach (ObjectCommunication toy in toys) {
            toy.SetInteractionMode(InteractionMode.Speak);
        }
    }
}
