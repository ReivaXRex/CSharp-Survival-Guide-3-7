using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedAdjust : MonoBehaviour
{
    [SerializeField] int speed;

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.S) || speed == 0)  // If the 'S' key is pressed or speed equals 0...
        {
            speed++; // Increase the speed by 1.
        }
        else if (Input.GetKeyDown(KeyCode.A))  // If the 'A' key is pressed...
        {
            speed--; // Decrease the speed by 1.
        }

        if (speed > 20) // If speed is greater than 20.
        {
            Debug.Log("Slow down!");
        }
        else if (speed == 0) // If speed is equal to 0.
        {
            Debug.Log("Speed Up!");
        }
    }
}
