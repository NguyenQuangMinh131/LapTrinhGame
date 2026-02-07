using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTest : MonoBehaviour
{
    public float forceAmount = 50f; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.forward * forceAmount, ForceMode.Impulse);
            
            Debug.Log("Bùm! Đã bắn lực: " + forceAmount);
        }
    }
}