using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    private Collider platformCollider; // Collider của sàn
    private Collider playerCollider;   // Collider của người chơi
    
    // Khoảng đệm để tránh bị kẹt khi đứng mép sàn (chỉnh nhỏ thôi)
    public float penetrationOffset = 0.1f; 

    void Start()
    {
        // 1. Lấy Collider của chính cái sàn này
        platformCollider = GetComponent<Collider>();

        // 2. Tìm Player trong game (Tìm theo tên "Player" hoặc Tag)
        // Đảm bảo nhân vật của bạn trong Hierarchy tên là "Player" nhé!
        GameObject playerObj = GameObject.Find("Player");
        
        if (playerObj != null)
        {
            // CharacterController cũng được tính là một dạng Collider
            playerCollider = playerObj.GetComponent<Collider>();
        }
        else
        {
            Debug.LogError("Không tìm thấy Player! Hãy đổi tên nhân vật thành 'Player'.");
        }
    }

    void Update()
    {
        // Nếu chưa tìm thấy Player thì không làm gì cả
        if (playerCollider == null || platformCollider == null) return;

        // --- TÍNH TOÁN VỊ TRÍ ---
        // Lấy vị trí thấp nhất của chân nhân vật (bounds.min.y)
        float playerFeetY = playerCollider.bounds.min.y;

        // Lấy vị trí cao nhất của mặt sàn (bounds.max.y)
        float platformTopY = platformCollider.bounds.max.y;

        // --- XỬ LÝ VA CHẠM ---
        // Nếu chân cao hơn mặt sàn (đang đứng trên hoặc rơi từ trên xuống)
        // Trừ đi một chút offset để nó không bị nhấp nháy
        bool isAbove = playerFeetY > (platformTopY - penetrationOffset);

        // Physics.IgnoreCollision(A, B, true) nghĩa là "Bỏ qua va chạm" (Đi xuyên)
        // Physics.IgnoreCollision(A, B, false) nghĩa là "Tính va chạm" (Cứng)
        
        // Nếu ĐANG Ở TRÊN -> KHÔNG BỎ QUA va chạm (Ignore = false) -> Cứng
        // Nếu ĐANG Ở DƯỚI -> BỎ QUA va chạm (Ignore = true) -> Xuyên
        Physics.IgnoreCollision(playerCollider, platformCollider, !isAbove);
    }
}