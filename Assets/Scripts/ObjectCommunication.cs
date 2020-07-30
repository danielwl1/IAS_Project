using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCommunication : MonoBehaviour
{
    [SerializeField] private Material highlightedMaterial;
    [SerializeField] private Material defaultMaterial;

    private bool selected;
    private string currentAnimation;
    private Animator animator;
    private MeshRenderer mesh;

    //Start is called before the first frame update
    void Start()
    {
        selected = false;
        animator = GetComponent<Animator>();
        mesh = GetComponent<MeshRenderer>();
        currentAnimation = "Obj_Idle";
    }

    private void Update()
    {
        animator.Play(currentAnimation);
    }



    //Sets UsageMod of selected Objects and changes materials them
    public void Select() {
        selected = !selected;
        if (selected)
        {
            mesh.material = highlightedMaterial;
        }
        else
        {
            mesh.material = defaultMaterial;
        }
    }

    //Starts animation after Button got pressed
    public void StartAnimation(string animationMode) {
        if (selected)
        {
            currentAnimation = animationMode;
            selected = false;
            mesh.material = defaultMaterial;        
        }
    }

    public void ResetAnimation(string buttonAction)
    {
        if (currentAnimation.Equals(buttonAction))
        {
            currentAnimation = "Obj_Idle";
        }
    }
}
