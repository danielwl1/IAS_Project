using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelectionManager : MonoBehaviour
{

    [SerializeField] private string selectionTag = "Selectable";

    // Start is called before the first frame update
    void Start()
    {
        
    }

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

                    switch (objectName) {
                        case "RabbitBody":

                            selection.transform.GetComponent<ObjectCommunication>().SetUsageMod();

                            break;
                        case "SheepBody":
                            selection.transform.GetComponent<ObjectCommunication>().SetUsageMod();
                            break;
                    }

                }
            
            }
        }

    }
}
