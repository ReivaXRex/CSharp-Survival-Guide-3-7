using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayChallenge2 : MonoBehaviour
{
    // Display a random value from the arrays.

    [SerializeField] string[] names = new string[5] { "Alan", "Bob", "Charles", "David", "Ethan" };
    [SerializeField] int[] ages = new int[5] { 16, 17, 18, 19, 20 };
    [SerializeField] string[] carModels = new string[5] { "BMW", "Honda", "Toyota", "Ford", "Chrysler" };
    public int randomNumber;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomNumber = Random.Range(0, names.Length);
            Debug.Log(randomNumber);
            Debug.Log("Name: " + names[randomNumber] + "   " + "Age: " + ages[randomNumber] + "   " + "Car Model: " + carModels[randomNumber]);
        }
    }
}
