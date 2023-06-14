using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InputButtons : Selectable, IPointerClickHandler, IPointerUpHandler, IPointerExitHandler
{
    GameManager gameManager;
    Selections selections;
    [SerializeField] public string inputTing;
    [SerializeField] public string inputedTing;


    void Start()
    {
        inputedTing = "#";
        //selections.selectedBox.GetComponentInChildren<Text>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (selections.selected == true && selections.Inserted == false)
        {
            if (inputTing == selections.requiredTing)
            {
                inputedTing = selections.requiredTing;
                gameManager.Correct++;
                selections.selected = false;
            }
            else
            {
                gameManager.Mistakes++;
                selections.selected = false;
            }
        }
    }
}
