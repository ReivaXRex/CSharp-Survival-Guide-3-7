using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterateUsingForLoop : MonoBehaviour
{
    // Iterate through an array using a For Loop.
    
    [SerializeField] int[] itemID = new int[3] { 0, 1, 2 };
    [SerializeField] string[] itemName = new string[3] { "Axe", "Bow", "Sword" };

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < itemName.Length; i++)
            {
                if (itemName[i] == "Sword")
                {
                    Debug.Log("Item Exists!");
                    Debug.Log("ItemID: " + itemID[i]);
                }
            }
        }
    }
}
