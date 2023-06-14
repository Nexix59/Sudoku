using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Selections : Selectable, IPointerClickHandler, ISubmitHandler, IPointerUpHandler, IPointerExitHandler
{
    [SerializeField] public GameObject selectedText;
    [SerializeField] public string requiredTing;
    GameManager gameManager;
    InputButtons inputButtons;
    public bool selected;
    public bool Inserted;

    public bool IsSelected() { return selected; }

    public void Start()
    {
        selected = false;
        selectedText.GetComponent<TextMeshProUGUI>().text = "#";
    }

    public void DisplatText()
    {
        if (selectedText.GetComponent<TextMeshProUGUI>().text == "#")
        {
            selectedText.GetComponent<TextMeshProUGUI>().text = " ";
        }

        selectedText.GetComponent<TextMeshProUGUI>().text = inputButtons.inputedTing;

        if (selectedText.GetComponent<TextMeshProUGUI>().text == requiredTing)
        {
            Inserted = true;
        }

        
    }

    public void Update()
    {
        
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        selected = true;
    }

    public void OnSubmit(BaseEventData eventData)
    {

    }


}
