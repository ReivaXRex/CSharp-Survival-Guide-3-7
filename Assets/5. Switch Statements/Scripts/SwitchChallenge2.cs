using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchChallenge2 : MonoBehaviour
{   
    // Use a switch statement to change the color of a GameObject using keyboard input.
  
    [SerializeField] int colorNumber;
    Renderer m_renderer;

    void Start()
    {
        m_renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            colorNumber = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            colorNumber = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            colorNumber = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            colorNumber = 4;
        }

        switch (colorNumber)
        {
            case 1:
                m_renderer.material.color = Color.blue;
                break;
            case 2:
                m_renderer.material.color = Color.red;
                break;
            case 3:
                m_renderer.material.color = Color.green;
                break;
            case 4:
                m_renderer.material.color = Color.black;
                break;
            default:
                Debug.Log("Invalid Input.");
                break;
        }
    }
}
