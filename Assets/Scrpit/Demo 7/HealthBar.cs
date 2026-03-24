using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform mask; // Kéo thả object Mask vào đây
    public Health health; // Kéo thả object Player (chứa script Health) vào đây
    
    private float originalWidth;

    void Start()
    {
        originalWidth = mask.sizeDelta.x;
        UpdateHealthValue();
        
        // Đăng ký lắng nghe sự kiện: hễ máu đổi là gọi hàm UpdateHealthValue
        health.onHealthChanged += UpdateHealthValue; 
    }

    private void UpdateHealthValue()
    {
        // Tính toán tỷ lệ phần trăm máu còn lại
        float scale = (float)health.healthPoint / health.defaultHealthPoint; 
        
        // Cập nhật lại chiều rộng của Mask dựa trên tỷ lệ đó
        mask.sizeDelta = new Vector2(scale * originalWidth, mask.sizeDelta.y); 
    }
}