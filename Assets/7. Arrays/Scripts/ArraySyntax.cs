using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySyntax : MonoBehaviour
{
    // Various methods for creating an array.


    // Basic and most common way of creating an array.
    [SerializeField] string[] names;

    // Create an array while also establishing it's size.
    [SerializeField] string[] enemyNames = new string[5]; 

    // Create and array declaring it's size and the values found within.
    [SerializeField] int[] ages = new int[] { 5, 16, 28, 30, 49 }; 

    private void Start()
    {
        enemyNames[0] = "Bob";
        enemyNames[1] = "Rick";
        enemyNames[2] = "John";
    }
}
