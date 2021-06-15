using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterateUsingForEach : MonoBehaviour
{
    // Iterate through an array using a ForEach Loop.

    [SerializeField] int[] ages = new int[4] { 20, 22, 24, 26 };

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var age in ages)
            {
                Debug.Log(age);
            }
        }
    }
}
