using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    [SerializeField] int playerScore;
    [SerializeField] bool messagePrinted;

    // public GameObject cubeObject;
    
    // Create a reference to the Cube's Renderer component.
    [SerializeField] Renderer cube;

    void Start()
    {
        // Assign the reference to the component and change the color of the cube to red.
        cube = GameObject.FindGameObjectWithTag("Player").GetComponent<Renderer>();
        cube.material.color = Color.red;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Increase the player's score by 10 whenever the 'Space' key is pressed.
        {
            playerScore += 10;
        }

        if (playerScore == 50 && !messagePrinted) // If the player's score is greater than or equal to 50 and the message 
        {                                         // hasn't been printed to the Console once already...
            Debug.Log("Nice!");
            messagePrinted = true;
            cube.material.color = Color.green;
            // cubeObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
