using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArithmeticOperators : MonoBehaviour
{
    [SerializeField] private int sum;
    [SerializeField] private int difference;
    [SerializeField] private int product;
    [SerializeField] private int quotient;
    [SerializeField] private int remainder;
    void Start()
    {
        sum = 10 + 5;
        difference = 10 - 5;
        product = 10 * 5;
        quotient = 10 / 5;
        remainder = 10 % 5;
        Debug.Log("Sum: " + sum);
        Debug.Log("Difference: " + difference);
        Debug.Log("Product: " + product);
        Debug.Log("Quotient: " + quotient);
        Debug.Log("Remainder: " + remainder);
    }
}