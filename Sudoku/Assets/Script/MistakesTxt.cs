using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MistakesTxt : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI MistakeCounter;
    [SerializeField] public GameObject Manger;
    [SerializeField] public GameObject Stoop;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MistakeCounter.GetComponent<TextMeshProUGUI>().text = "Live: " +
        (Manger.GetComponent<GameManager>().Mistakes.ToString()) + "/3";
        Debug.Log("Whatttttt" + Manger.GetComponent<GameManager>().Mistakes.ToString());
        Debug.Log("Whatttttt" + Manger.GetComponent<GameManager>().Mistakes);
    }
}
