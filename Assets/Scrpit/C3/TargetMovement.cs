using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [Header("Cài đặt")]
    public float moveSpeed = 5f; // Tốc độ di chuyển

    void Update()
    {
        float x = 0; // Trục ngang (Trái/Phải)
        float z = 0; // Trục dọc (Tiến/Lùi)

        // 1. Kiểm tra phím bấm (TFGH)
        // Tiến (T)
        if (Input.GetKey(KeyCode.T)) 
        {
            z = 1; 
        }
        // Lùi (G)
        else if (Input.GetKey(KeyCode.G)) 
        {
            z = -1;
        }

        // Sang Phải (H)
        if (Input.GetKey(KeyCode.H)) 
        {
            x = 1;
        }
        // Sang Trái (F)
        else if (Input.GetKey(KeyCode.F)) 
        {
            x = -1;
        }

        // 2. Tạo vector hướng
        Vector3 moveDir = new Vector3(x, 0, z);

        // 3. Chuẩn hóa vector (Tránh đi chéo bị nhanh)
        if (moveDir.magnitude > 1)
        {
            moveDir.Normalize();
        }

        // 4. Di chuyển (Theo hệ quy chiếu thế giới - World Space)
        // Dùng Space.World để khi target xoay, hướng đi vẫn cố định (T luôn là đi lên trên màn hình)
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
    }
}