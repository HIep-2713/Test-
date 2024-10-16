using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExample : MonoBehaviour
{
    [SerializeField] private string playerName;
    void Start()
    {
        Debug.Log("Player Name: " + playerName);
    }
}

