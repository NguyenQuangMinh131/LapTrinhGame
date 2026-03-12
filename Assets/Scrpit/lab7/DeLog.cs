using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeLog : MonoBehaviour
{
    public void LogMessage(string message)
    {
        Debug.Log("Button clicked: " + message);
    }
}