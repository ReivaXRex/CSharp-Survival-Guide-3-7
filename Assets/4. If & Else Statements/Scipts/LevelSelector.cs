using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    // A basic example of a difficulty selector using if and else/if statements.
    
    private int easyDifficulty = 1;
    private int mediumDifficulty = 2;
    private int hardDifficulty = 3;
    [SerializeField] int currentDifficulty;

    void Update()
    {
        if (currentDifficulty == easyDifficulty)
        {
            Debug.Log("You selected Easy Difficulty.");
        }
        else if (currentDifficulty == mediumDifficulty)
        {
            Debug.Log("You selected Medium Difficulty.");
        }
        else if (currentDifficulty == hardDifficulty)
        {
            Debug.Log("You selected Hard Difficulty.");
        }
        else
        {
            Debug.Log("Invalid difficulty selected.");
        }
    }
}
