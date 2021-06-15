using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemEx
{
    public int itemIDEX;
    public string nameEX;
    public string descriptionEX;

}

public class ItemExample : MonoBehaviour
{
    public ItemEx[] myItems;

    void Start()
    {
        foreach (var item in myItems)
        {
            Debug.Log(item.nameEX);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomID = Random.Range(0, myItems.Length);

                Debug.Log(myItems[randomID].nameEX);           
        }
    }
}
