using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log(i);

            if (i == 50)
            {
                break;
            }
        }
    }
}
