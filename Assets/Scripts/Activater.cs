using UnityEngine;

public class Activater : MonoBehaviour
{
    private UnityEngine.UI.Button button;
    private RectTransform currentRect;


    private void Start()
    {
        button = GetComponent<UnityEngine.UI.Button>();
        currentRect = GetComponent<RectTransform>();

    }
    public void UpdateInteraction(Vector2 pos, Vector2 newPos)
    {
        if (pos.Equals(newPos + currentRect.anchoredPosition))
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
}
