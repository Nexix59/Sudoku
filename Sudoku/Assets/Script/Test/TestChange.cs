using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestChange : MonoBehaviour
{
    [SerializeField] public string Nombre;
    Stuff stuff;
    public GameObject Selecto;

    private static TestChange _innstance;

    public static TestChange Instance { get { return _innstance; } }

    private void Awake()
    {
        if (_innstance != null && _innstance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _innstance = this;
        }
    }
    private void Update()
    {
        
    }

    public void ChangeNombre()
    {
        //Selecto = stuff.Selecti;
        
        Debug.Log(stuff.Selecti);


        /*
        if (Selecto.GetComponent<Requirement>().RequiredNombre == Nombre)
        {
            Selecto.GetComponentInChildren<TextMeshProUGUI>().text = Nombre;
            Debug.Log(Selecto.GetComponent<Requirement>().RequiredNombre);
            Debug.Log("Changed");
        }
        else
        {
            Selecto.GetComponentInChildren<TextMeshProUGUI>().text = " ";
            Debug.Log("Nope");
        }
        Debug.Log("Oof");*/

        
        if (stuff.SelectedCube[0].GetComponent<Requirement>().RequiredNombre == Nombre)
        {
            stuff.SelectedCube[0].GetComponentInChildren<TextMeshProUGUI>().text = Nombre;
            Debug.Log(stuff.SelectedCube[0].GetComponent<Requirement>().RequiredNombre);
            Debug.Log("Changed");
        }
        else
        {
            stuff.SelectedCube[0].GetComponentInChildren<TextMeshProUGUI>().text = " ";
            Debug.Log("Nope");
        }
        Debug.Log("Oof");
        
    }
}
