using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    // 1. Xử lý va chạm CỨNG (Đâm vào tường)
    private void OnCollisionEnter(Collision collision)
    {
        // In ra tên vật cản
        Debug.Log("Cốp! Đâm đầu vào: " + collision.gameObject.name);
        
        // Đổi màu Player thành Đỏ báo hiệu đau
        GetComponent<Renderer>().material.color = Color.red;
    }

    // 2. Xử lý vùng TRIGGER (Đi xuyên qua)
    private void OnTriggerEnter(Collider other)
    {
        // In ra tên vùng vừa đi qua
        Debug.Log("Vụt! Đi xuyên qua vùng ảo: " + other.gameObject.name);
        
        // Đổi màu Player thành Xanh báo hiệu an toàn
        GetComponent<Renderer>().material.color = Color.green;
    }

    // Tự động reset màu khi ra khỏi Trigger (Optional - cho xịn)
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Đã thoát khỏi vùng: " + other.gameObject.name);
        GetComponent<Renderer>().material.color = Color.white;
    }
}