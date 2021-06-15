using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    /// <summary>
    /// GameObject to aim/look at.
    /// </summary>
    [SerializeField] Transform aimTarget;

    // Update is called once per frame
    void Update()
    {
        // direction = destination - source. Calculate direction to face.
        Vector3 directionToFace = aimTarget.position - transform.position;
        
        // Draw out a green line towards where the object is looking.
        Debug.DrawRay(transform.position, directionToFace, Color.green);

        // Access our current rotation and assign it the value of the Quaternion Look Rotation method.
        // transform.rotation = Quaternion.LookRotation(directionToFace);

        // Store the look rotation within a quaternion variable. (Where the object is going to look)
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        // Smoothly look towards the target.
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
    }
}
