using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -20f; // Trọng lực
    public float jumpHeight = 2f; // Độ cao nhảy

    private CharacterController controller;
    private Vector3 velocity;
    
    // Biến này để tự mình kiểm tra đất
    private bool isGrounded; 

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // --- CÁCH CHECK ĐẤT MỚI (RAYCAST) ---
        // Bắn 1 tia từ tâm nhân vật xuống dưới chân
        // Length = 1.1f (Vì chiều cao nhân vật là 2, nên từ tâm xuống chân là 1. Thêm 0.1 dư ra để chạm đất)
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        // Vẽ tia màu đỏ trong Scene để bạn thấy nó hoạt động
        Debug.DrawRay(transform.position, Vector3.down * 1.1f, Color.red);

        // Reset trọng lực khi chạm đất
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -5f; // Ép mạnh xuống đất cho dính chặt
        }

        // --- DI CHUYỂN ---
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        // --- NHẢY ---
        // Chỉ cần biến isGrounded của mình = true là nhảy
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                Debug.Log("Nhảy thành công!");
            }
            else
            {
                Debug.Log("Vẫn chưa chạm đất (Raycast không trúng)");
            }
        }

        // --- RƠI ---
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}