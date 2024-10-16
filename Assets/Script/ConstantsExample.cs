using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantsExample : MonoBehaviour
{
    private const float PI = 3.14f;
    private const int DAYS_IN_WEEK = 7;
    void Start()
    {

        Debug.Log("PI: " + PI);
        Debug.Log("Days in a week: " + DAYS_IN_WEEK);
    }
}
