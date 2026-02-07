using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPush : MonoBehaviour
{
    public float pushPower = 2.0f; // Lực đẩy mạnh hay yếu

    // Hàm này tự động chạy khi Character Controller đụng vào vật gì đó
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // 1. Kiểm tra xem vật bị đụng có Rigidbody không
        Rigidbody body = hit.collider.attachedRigidbody;

        // Nếu không có Rigidbody hoặc vật đó bị khóa (IsKinematic), thì thôi
        if (body == null || body.isKinematic) 
        {
            return;
        }

        // 2. Không đẩy vật thể ở dưới chân (sàn nhà), chỉ đẩy vật ngang hông
        if (hit.moveDirection.y < -0.3f) 
        {
            return;
        }

        // 3. Tính hướng đẩy (chỉ đẩy theo phương ngang x, z)
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        // 4. Áp dụng lực đẩy
        body.velocity = pushDir * pushPower;
    }
}