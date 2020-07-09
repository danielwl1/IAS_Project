using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private bool buttonState;
    private ObjectCommunication[] toys;
    void Start()
    {
        buttonState = false;
        toys = GetComponentsInChildren<ObjectCommunication>();
    }

    public void MessageButtonIsPressed()
    {

        foreach (ObjectCommunication toy in toys)
        {
            if (!buttonState)
            {
                toy.SetInteractionMode(InteractionMode.Speak);
            }
            else
            {
                toy.SetInteractionMode(InteractionMode.Idle);
            }
        }
        buttonState = !buttonState;

    }
}
