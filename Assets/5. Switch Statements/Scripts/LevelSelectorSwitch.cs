using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectorSwitch : MonoBehaviour
{
    // Convert an existing if-else statement into a switch statement format.

    int easyDifficulty = 0;
    int mediumDifficulty = 1;
    int hardDifficulty = 2;

    public int currentDifficulty;

    void Start()
    {
        currentDifficulty = Random.Range(0, 3);
    }

    void Update()
    {
        /*   
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
        */

        switch (currentDifficulty)
        {
            case 0:
                Debug.Log("You selected Easy Difficulty.");
                break;
            
            case 1:
                Debug.Log("You selected Medium Difficulty.");
                break;

            case 2:
                Debug.Log("You selected Hard Difficulty.");
                break;

            default:
                Debug.Log("Invalid difficulty selected.");
                break;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            currentDifficulty = Random.Range(0, 3);
        }
    }
}
