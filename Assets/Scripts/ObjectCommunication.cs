using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCommunication : MonoBehaviour
{
    [SerializeField] private Material highlightedMaterial;
    [SerializeField] private Material defaultMaterial; 
    private bool UsageMod, allowInteraction;
    private Animator animator;
    private InteractionMode interaction;
    private MeshRenderer mesh;

    // Start is called before the first frame update
    void Start()
    {
        allowInteraction = false;
        UsageMod = false;
        animator = GetComponent<Animator>();
        mesh = GetComponent<MeshRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (UsageMod && allowInteraction)
        {
            switch (interaction)
            {
                case InteractionMode.Speak:
                    print("hier alles ok");
                    animator.Play("Obj_Speak");
                    break;
                case InteractionMode.Idle:
                    animator.Play("Obj_Idle");
                    break;
                case InteractionMode.Love:
                    animator.Play("Obj_Idle");
                    break;
                default:
                    animator.Play("Obj_Idle");
                    break;
            }
        }
        else
        {
            animator.Play("Obj_Idle");
        }

    }

    //sets UsageMod of selected Objects and changes materials them
    public void SetUsageMod() {
        UsageMod = !UsageMod;
        
        if (UsageMod)
        {
            mesh.material = highlightedMaterial;
        }
        else {
            mesh.material = defaultMaterial;
        }

    }
    public void SetInteractionMode(InteractionMode mode) {
        allowInteraction = !allowInteraction;
        mesh.material = defaultMaterial;
        interaction = mode;
    }
}
