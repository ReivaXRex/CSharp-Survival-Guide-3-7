using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While2 : MonoBehaviour
{
    // While apples is less than 50, increase the value of apples by 1 and log the value of apples to the Console.

    [SerializeField] int apples;
    
    void Start()
    {
        while (apples < 50)
        {
            Debug.Log(apples);
            apples++;
        }
    }

}
