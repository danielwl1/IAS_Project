using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwiper : MonoBehaviour
{
    private RectTransform panel, canvas;
    private GameObject[] childs;
    private Vector2 nullPos;

    // Start is called before the first frame update
    void Start()
    {
        panel = GetComponent<RectTransform>();
        childs = GameObject.FindGameObjectsWithTag("Button");
        canvas = GetComponentInParent<RectTransform>();
        nullPos = panel.anchoredPosition;

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.touchCount > 0)
        {

            Vector2 currentPos = Swipe(Input.GetTouch(0));
            foreach (GameObject child in childs)
            {
                child.GetComponent<Activater>().UpdateInteraction(nullPos, currentPos);

            }
        }
    }



    private Vector2 Swipe(Touch input)
    {

        float newX;
        if (panel.rect.Contains(input.rawPosition))
        {
            float distance = input.deltaPosition.magnitude;
            if (input.rawPosition.x > input.position.x)
            {
                distance *= -1;
            }

            newX = panel.anchoredPosition.x + distance;
            if (input.phase == TouchPhase.Ended)
            {
                float adjustment = Math.Abs(newX) % 150;
                if (newX < 0)
                {
                    if (adjustment < 75)
                    {
                        newX += adjustment;
                    }
                    else
                    {
                        newX -= (150 - adjustment);
                    }
                }
                else
                {
                    if (adjustment < 75)
                    {
                        newX -= adjustment;
                    }
                    else
                    {
                        newX += (150 - adjustment);
                    }
                }
            }

            if (canvas.rect.Contains(new Vector2(-1 * newX - 1, 0)))
            {

                panel.anchoredPosition = new Vector2(newX, panel.anchoredPosition.y);

            }

        }
        return panel.anchoredPosition;
    }
}
