using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Cài đặt")]
    public float moveSpeed = 5f; // Tốc độ di chuyển

    // Biến lưu hướng để vẽ Gizmos (Debug)
    private Vector3 moveDirection;

    void Update()
    {
        // 1. Lấy tín hiệu từ bàn phím (WASD hoặc Mũi tên)
        // GetAxisRaw trả về -1, 0, hoặc 1 ngay lập tức (không có gia tốc mềm) -> Giúp di chuyển dứt khoát
        float horizontal = Input.GetAxisRaw("Horizontal"); // A/D
        float vertical = Input.GetAxisRaw("Vertical");     // W/S

        // 2. Tạo Vector hướng đi
        // Trục Y để 0 vì chúng ta không muốn nhân vật bay lên trời
        Vector3 inputVector = new Vector3(horizontal, 0, vertical);

        // 3. Xử lý Chuẩn hóa (Normalize) - Yêu cầu quan trọng của Lab
        if (inputVector.magnitude > 0)
        {
            // normalized trả về một vector có cùng hướng nhưng độ dài (magnitude) luôn bằng 1
            moveDirection = inputVector.normalized;
        }
        else
        {
            moveDirection = Vector3.zero;
        }

        // 4. Thực hiện di chuyển
        // Space.World: Để đảm bảo di chuyển theo trục của thế giới (không bị lệch nếu nhân vật xoay)
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }

    // 5. Vẽ Gizmos (Yêu cầu hiển thị hướng)
    void OnDrawGizmos()
    {
        // Vẽ một quả cầu vàng ở vị trí nhân vật để dễ nhìn
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, 0.5f);

        // Vẽ tia màu đỏ chỉ hướng di chuyển
        // Chỉ vẽ khi có hướng (vector khác 0)
        if (moveDirection.magnitude > 0)
        {
            Gizmos.color = Color.red;
            
            // Vẽ tia từ vị trí nhân vật, dài ra 2 mét theo hướng di chuyển
            Vector3 startPoint = transform.position;
            Vector3 endPoint = startPoint + (moveDirection * 2f);
            
            Gizmos.DrawLine(startPoint, endPoint);
            
            // Vẽ thêm 1 cục cube nhỏ ở đầu mút để làm mũi tên
            Gizmos.DrawCube(endPoint, Vector3.one * 0.2f);
        }
    }
}