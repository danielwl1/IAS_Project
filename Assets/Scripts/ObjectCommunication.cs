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

    // Start is called before the first frame update
    void Start()
    {
        allowInteraction = false;
        UsageMod = false;
        animator = GetComponent<Animator>();
  
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
                case InteractionMode.Walk:
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
        else {
            animator.Play("Obj_Idle");
        }
            
    }
    public void SetUsageMod() {
        UsageMod = !UsageMod;
        MeshRenderer [] children = GetComponentsInChildren<MeshRenderer>();
        if (UsageMod)
        {
            highlightChildren(highlightedMaterial, children);
        }
        else {
            highlightChildren(defaultMaterial, children);
        }

    }
    public void SetInteractionMode(InteractionMode mode) {
        allowInteraction = !allowInteraction;
        interaction = mode;
    }

    //colors the selected Objects
    private void highlightChildren(Material material, MeshRenderer[] childs) {
        foreach (MeshRenderer child in childs)
        {
            child.material = highlightedMaterial;
        }
    }
}
