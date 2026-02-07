using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor3D : MonoBehaviour
{
    public float speed = 3.0f; // Tốc độ trôi
    public Vector3 direction = Vector3.forward; // Hướng trôi (mặc định là phía trước)
    
    // Xử lý khi có vật thể Rigidbody chạm vào
    void OnCollisionStay(Collision collision)
    {
        // Đẩy vật thể đi
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
        }
    }
}