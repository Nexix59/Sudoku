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
    GameManager gameManager;

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
    }

    public void ClickSelect(GameObject unitToAdd)
    {
        DeselectAll();
        SelectedCube.Add(unitToAdd);
        Debug.Log(unitToAdd.GetComponent<Requirement>().RequiredNombre);
        Selecti = unitToAdd;
        Debug.Log(Selecti);
        //unitToAdd.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void DeselectAll()
    {
        /*foreach (var unit in SelectedCube)
        {
            unit.transform.GetChild(0).gameObject.SetActive(false);
        }*/

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
            gameManager.Correct++;
            //Debug.Log(SelectedCube[0].GetComponent<Requirement>().RequiredNombre);
            Debug.Log("Changed");
            Debug.Log(gameManager.Correct);
        } else
        {
            gameManager.Mistakes++;
            Debug.Log("Nope");
            Debug.Log(gameManager.Mistakes);
        }
        Debug.Log("Oof");   
    }
    
    void Update()
    {

    }
}
