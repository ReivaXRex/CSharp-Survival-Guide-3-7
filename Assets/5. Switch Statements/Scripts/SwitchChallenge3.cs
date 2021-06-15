using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchChallenge3 : MonoBehaviour
{
    /// <summary>
    /// Simple weapon selection logic using a switch statement.
    /// </summary>
   
    [SerializeField] int weaponID;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponID = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponID = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weaponID = 3;
        }
       
        switch (weaponID)
        {
            case 1:
                Debug.Log("Gun selected");
                break;
            case 2:
                Debug.Log("Machine Gun selected");
                break;
            case 3:
                Debug.Log("Knife selected");
                break;
        }
    }
}
