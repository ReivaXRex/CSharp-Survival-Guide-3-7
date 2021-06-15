using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    float billAmount = 40.0f;
    [SerializeField] float tipRate = 20.00f;
    float tipAmount;
    float totalAmount;

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the amount of the tip by multiply the bill amount by the tipRate converted into a percentage (20%).
        tipAmount = billAmount * (tipRate / 100);
        // Calculate the total amount by adding the billAmount and the tipAmount.
        totalAmount = billAmount + tipAmount;

        Debug.Log("Your bill is $" + billAmount + " and your tip is $" + tipAmount);
        Debug.Log("You owe $" + totalAmount + " sir.");

    }

}
