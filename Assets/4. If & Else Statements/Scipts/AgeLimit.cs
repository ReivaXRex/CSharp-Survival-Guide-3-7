using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeLimit : MonoBehaviour
{
    [SerializeField] int age;
    [SerializeField] int ageLimit = 16;

    void Start()
    {
        if (age < ageLimit) // If the age is greater than the age limit...
        {
            Debug.Log("You're not old enough to drive.");
        }
        else // If not
        {
            Debug.Log("You're old enough to drive");
        }
    }

}
