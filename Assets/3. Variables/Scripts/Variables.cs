using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Three components to a variable:
    // Accesser -  public or private
    // Data type (most common: string, bool, float, int)
    // A name
    // Optional -- value

    [SerializeField] string myName;
    [SerializeField] string myLocation;
    [SerializeField] int myAge;
    [SerializeField] float playerSpeed;
    // public float speed;
    [SerializeField] int health;
    [SerializeField] int score;
    [SerializeField] int ammoCount;
    [SerializeField] bool allKeysCollected; // defaults to false.


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is " + myName);
        Debug.Log("My age is " + myAge);
        Debug.Log("My location is " + myLocation);
        Debug.Log("My current speed is " + playerSpeed);
        // Debug.Log("My location is " + speed);
        Debug.Log("My current health is " + health);
        Debug.Log("My current score is " + score);
        Debug.Log("My current amount of ammo is " + ammoCount + " bullets");
        Debug.Log("Do I have all the keys in the area? " + allKeysCollected);
        

    }

}
