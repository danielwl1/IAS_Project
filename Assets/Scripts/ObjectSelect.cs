using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Vuforia;

public class ObjectBehavior : MonoBehaviour
{
    string objectName;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                objectName = Hit.transform.name;
                print(objectName);

                switch (objectName)
                {
                    case "RabbitBody":
                             
                        break;

                    case "SheepBody":
                        
                        break;
                    default:
                        break;
                }
            }

        }
    }

    
}
