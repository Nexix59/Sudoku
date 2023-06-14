using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    InputButtons inputButtons;
    [SerializeField] public int Mistakes;
    [SerializeField] public bool Lose;
    [SerializeField] public int Correct;
    [SerializeField] public bool Won;

    private void Awake()
    {
        Mistakes = 3;
        Lose = false;
    }

    private void Update()
    {
        if(Correct >= 80)
        {
            Won = true;
        }

        if (Mistakes <= 1)
        {
            Lose = true;
        }
    }

    private void GameState()
    {
        if(Won == true  && Lose == false)
        {
            Debug.Log("WINNER");
        } 
        else if (Won == false && Lose == true)
        {
            Debug.Log("LOSER");
        }
    }
}
