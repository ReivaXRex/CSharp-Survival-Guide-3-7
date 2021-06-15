using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    // Cube gameObject that will be spawned in.
    
    [SerializeField] GameObject cubePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // If the Space key is pressed.
        {
            //  Instantiate(cubePrefab, Vector3.zero, Quaternion.identity); - Spawn a cube with no rotation.
            Instantiate(cubePrefab, Vector3.zero, Quaternion.Euler(0, 35, 0)); // Spawn a cube with an euler angle of 35 along the y axis.
        }
        
    }
}
