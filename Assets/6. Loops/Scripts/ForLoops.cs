using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    [SerializeField] string myName = "Xavier";

    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log(myName);
        }

        Debug.Log("Loop has finished");

        // Print out only even numbers ( == 1 for odd)
        for (int i = 0; i < 100; i++)
        {
            Debug.Log(i);
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        // Reversed
        for (int i = 100; i > 0; i--)
        {
            Debug.Log(i);
        }
    }
}
