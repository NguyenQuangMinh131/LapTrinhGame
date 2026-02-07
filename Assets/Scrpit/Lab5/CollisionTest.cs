using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // 1. Xử lý va chạm CỨNG (Collision)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Úi da! Đã va chạm với: " + collision.gameObject.name);
        
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    // 2. Xử lý va chạm MỀM (Trigger)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ting ting! Đã đi vào vùng Trigger: " + collision.gameObject.name);

        GetComponent<SpriteRenderer>().color = Color.green;
    }
}