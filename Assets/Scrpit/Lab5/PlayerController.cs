using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;    // Tốc độ chạy
    public float jumpForce = 10f;   // Lực nhảy
    
    private Rigidbody2D rb;
    private bool isGrounded = false; // Biến kiểm tra xem có đang chạm đất không

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // --- 1. DI CHUYỂN TRÁI / PHẢI ---
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput != 0) 
        {
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }

        // --- 2. NHẢY (JUMP) ---
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false; // Vừa nhảy xong thì tính là đang bay
        }
    }

    // --- 3. KIỂM TRA CHẠM ĐẤT (Liên quan Lab 2) ---
    // Khi chân chạm vào vật gì đó (Sàn)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Kiểm tra xem vật va chạm có phải là "Ground" (Sàn) không
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Đã tiếp đất, cho phép nhảy tiếp
            Debug.Log("Đã chạm đất!");
        }
    }
}