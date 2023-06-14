using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSelect : MonoBehaviour
{
    private Camera myCam;

    public LayerMask clickable;
    public LayerMask ground;

    
    void Start()
    {
        myCam = Camera.main;
    }

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = myCam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity, clickable))
            {
                Stuff.Instance.ClickSelect(hit.collider.gameObject);
            } 
            else
            {
                Stuff.Instance.DeselectAll();
            }
        }*/
    }

    public void Selection()
    {
        Stuff.Instance.ClickSelect(gameObject);
        Debug.Log("Selected");
    }
}
