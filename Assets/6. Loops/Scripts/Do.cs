using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do : MonoBehaviour
{
    // [SerializeField] int apples;
    int i;

    void Start()
    {
        do
        {
            // statement code
            Debug.Log(i);
            // apples++;
            i++;
            // index incrementer
        } while (i < 50);
    }
}
