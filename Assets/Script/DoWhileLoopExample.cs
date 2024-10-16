using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoopExample : MonoBehaviour
{
    [SerializeField] private int i = 0;
    void Start()

    {
        do
        {
            Debug.Log("i: " + i);
            i++;
        } while (i < 5);
    }
}
