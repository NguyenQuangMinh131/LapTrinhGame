using UnityEngine;
using TMPro;

public class ConfigDisplay : MonoBehaviour
{
    // Biến này để chứa file ScriptableObject
    public GameConfig currentConfig; 
    
    public TMP_Text displayText;

    // Dùng Update để khi bạn sửa data trong Inspector, màn hình game cập nhật theo ngay lập tức
    private void Update()
    {
        if (currentConfig != null && displayText != null)
        {
            displayText.text = "--- GAME CONFIG ---\n" +
                               $"Độ khó: {currentConfig.difficulty}\n" +
                               $"Máu khởi điểm: {currentConfig.startingHealth}\n" +
                               $"Tốc độ: {currentConfig.baseMoveSpeed}";
        }
    }
}