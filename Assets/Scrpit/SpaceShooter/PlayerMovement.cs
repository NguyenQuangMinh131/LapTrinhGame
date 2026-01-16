using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f; 
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(mousePos);
        worldPoint.z = 0; 
        transform.position = worldPoint;
    }
}