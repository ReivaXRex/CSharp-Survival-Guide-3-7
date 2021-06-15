using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayChallenge : MonoBehaviour
{
    // Declare and Access array data by creating several arrays, printing out the last value in each.
    
    [SerializeField] string[] names = new string[5] { "Alan", "Bob", "Charles", "David", "Ethan" };
    [SerializeField] int[] ages = new int[5] { 16, 17, 18, 19, 20 };
    [SerializeField] string[] carModels = new string[5] { "BMW", "Honda", "Toyota", "Ford", "Chrysler" };

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Name: " + names[4] + "   " + "Age: " + ages[4] + "   " + "Car Model: " + carModels[4]);
        }
    }
}
