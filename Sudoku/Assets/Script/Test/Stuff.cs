using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stuff : MonoBehaviour
{
    [SerializeField] public List<GameObject> Cubes = new List<GameObject>();
    [SerializeField] public List<GameObject> SelectedCube = new List<GameObject>();

    private static Stuff _instance;
    public GameObject Selecti;
    public GameObject GameManageral;

    public GameObject EndBack;
    public GameObject EndFront;
    public GameObject YouWon;
    public GameObject YouLost;
    public GameObject RestartButt;
    public GameObject MenuButt;

    [SerializeField] public string Nombre;

    public static Stuff Instance { get { return _instance; } }


    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        EndBack.SetActive(false);
        EndFront.SetActive(false);
        YouWon.SetActive(false);
        YouLost.SetActive(false);
        RestartButt.SetActive(false);
        MenuButt.SetActive(false);
    }

    public void ClickSelect(GameObject unitToAdd)
    {
        DeselectAll();
        SelectedCube.Add(unitToAdd);
        Debug.Log(unitToAdd.GetComponent<Requirement>().RequiredNombre);
        Selecti = unitToAdd;
        Debug.Log(Selecti);
    }

    public void DeselectAll()
    {
        SelectedCube.Clear();
    }

    public void Num1() { Nombre = "1"; }
    public void Num2() { Nombre = "2"; }
    public void Num3() { Nombre = "3"; }
    public void Num4() { Nombre = "4"; }
    public void Num5() { Nombre = "5"; }
    public void Num6() { Nombre = "6"; }
    public void Num7() { Nombre = "7"; }
    public void Num8() { Nombre = "8"; }
    public void Num9() { Nombre = "9"; }

    public void ChangeNombre()
    {

        if (Selecti.GetComponent<Requirement>().RequiredNombre == Nombre)
        {
            Selecti.GetComponentInChildren<TextMeshProUGUI>().text = Nombre;
            Selecti.GetComponent<Requirement>().RequiredNombre = "NYA";
            GameManageral.GetComponent<GameManager>().Correct++;
            Debug.Log("Changed");
            Debug.Log(GameManageral.GetComponent<GameManager>().Correct);
        } else
        {
            GameManageral.GetComponent<GameManager>().Mistakes--;
            Debug.Log("Nope");
            Debug.Log(GameManageral.GetComponent<GameManager>().Mistakes);
        }

        if (GameManageral.GetComponent<GameManager>().Won == true && GameManageral.GetComponent<GameManager>().Lose == false)
        {
            EndBack.SetActive(true);
            EndFront.SetActive(true);
            YouWon.SetActive(true);
            YouLost.SetActive(false);
            RestartButt.SetActive(true);
            MenuButt.SetActive(true);
            Debug.Log("WINNER");
        }
        
        if (GameManageral.GetComponent<GameManager>().Won == false && GameManageral.GetComponent<GameManager>().Lose == true)
        {
            EndBack.SetActive(true);
            EndFront.SetActive(true);
            YouWon.SetActive(false);
            YouLost.SetActive(true);
            RestartButt.SetActive(true);
            MenuButt.SetActive(true);
            Debug.Log("LOSER");
        }

    }

    void Update()
    {

    }
}
