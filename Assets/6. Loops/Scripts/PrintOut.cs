using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintOut : MonoBehaviour
{
    // Use a for loop to print out:
    // All numbers from 0 to 10
    // Even numbers from 10 to 20
    // Odd numbers from 20 to 30
   
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            if (i < 10)
            {
                Debug.Log(i);
            }

            if (i > 9 && i < 21)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
            else if (i > 20)
            {
                if (i % 2 == 1)
                {
                    Debug.Log(i);
                }
            }
        }
    }
}
