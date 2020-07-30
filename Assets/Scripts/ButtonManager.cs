using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private bool talkButtonState,loveButtonState,askButtonState;
    private ObjectCommunication[] toys;
    void Start()
    {
        talkButtonState = true;
        toys = GetComponentsInChildren<ObjectCommunication>();
    }

    public void ButtonGotPressed(string buttonName)
    {
        switch (buttonName)
        {
            case "talk":
                talkButtonState = IterateOverToys(talkButtonState, "Obj_Speak");
                break;
            case "love":
                loveButtonState = IterateOverToys(loveButtonState, "Obj_Love");
                break;
            case "ask":
                askButtonState = IterateOverToys(askButtonState, "Obj_Ask");
                break;
            default:
                break;

        }
    }

    
    private bool IterateOverToys(bool state, string mode) 
    {
        foreach (ObjectCommunication toy in toys)
        {
            if (state)
            {
                toy.StartAnimation(mode);
            }
            else
            {
                toy.ResetAnimation(mode);
            }
        }
        return !state;
    }
}


