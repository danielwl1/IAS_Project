using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitMovement : MonoBehaviour
{
    private bool enableMovement = false; 
    public void Update()
    {
        if (enableMovement)
        transform.position += transform.forward * Time.deltaTime;
    }

    public void StartMovement() {
        print("ich bin dumm");
        enableMovement = true;
    }
}
