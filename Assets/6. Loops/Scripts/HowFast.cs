using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowFast : MonoBehaviour
{
    // Create a program which will:
    // Increment the value of speed by 5 each second &
    // Stop once it reaches a set maxValue.
    
    [SerializeField] int speed;
    [SerializeField] int maxSpeed;

    void Start()
    {
        maxSpeed = Random.Range(60, 121);
        StartCoroutine(IncreaseSpeed());
    }

    IEnumerator IncreaseSpeed()
    {
        while (speed < maxSpeed)
        {
            speed += 5;
            yield return new WaitForSeconds(1.0f);
        }
    }
}
