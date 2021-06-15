using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    // Loop through an array of gameObjects and access their material to change their color.
    
    [SerializeField] GameObject[] cubes;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.red;
            }

        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }
    }
}
