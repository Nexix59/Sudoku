using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }

    public void Hell()
    {
        SceneManager.LoadScene(1);
    }

    public void Quity()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
