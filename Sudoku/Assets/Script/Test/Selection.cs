using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    [SerializeField] public GameObject selectedBox;
    [SerializeField] public bool isSelected;

    void Start()
    {
        Stuff.Instance.Cubes.Add(this.gameObject);
    }

    private void OnDestroy()
    {
        Stuff.Instance.Cubes.Remove(this.gameObject);
    }

    void Update()
    {
        
    }
}
