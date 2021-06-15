using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemExample2
{
    public int _itemID;
    public string _name;
    public string _description;
}

// Loop through an array and target a specific element.
// The Start method uses a ForEach loop and the Update method uses a For Loop.

public class SpecificInArray : MonoBehaviour
{
    public ItemExample2[] _myItems;

    void Start()
    {
        foreach (var item in _myItems)
        {
            if (item._itemID == 2)
            {
                Debug.Log("You have it!");
            }
            else
            {
                Debug.Log("You don't have this item");
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < _myItems.Length; i++)
            {
                if (_myItems[i]._itemID == 4)
                {
                    Debug.Log("You have it");
                }
                else
                {

                    Debug.Log("You don't have it.");
                }
            }
        }
    }
}
