using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ObjectSelectionManager : MonoBehaviour
{
    [SerializeField] private string selectionTag = "Selectable";

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0) {

           Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
           RaycastHit hit;     
           if (Physics.Raycast(ray, out hit)) {
                var selection = hit.transform;
                if (selection.CompareTag(selectionTag)) {
                    string objectName = selection.transform.name;

                    switch (objectName)
                    {
                        case "toybunny":
                            selection.transform.GetComponent<ObjectCommunication>().Select();
                            break;
                        case "toysheep":
                            selection.transform.GetComponent<ObjectCommunication>().Select();
                            break;
                        default:
                            break;
                    }
                }
           }
        }
    }

}
