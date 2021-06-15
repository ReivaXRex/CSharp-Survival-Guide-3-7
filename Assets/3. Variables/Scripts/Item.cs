using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    // Create variables that might be found on an item within an RPG.
    [SerializeField] string itemName;
    [SerializeField] string itemDescription;
    [SerializeField] Image itemImage;
    [SerializeField] Sprite itemSprite;
    [SerializeField] int attackStrength;
    
    // Start is called before the first frame update
    void Start()
    {
        // Print out the information stored within the variables to the console.
        Debug.Log("Name: " + itemName);
        Debug.Log("Description: " + itemDescription);
        Debug.Log("Attack Power: " + attackStrength);
    }

}
