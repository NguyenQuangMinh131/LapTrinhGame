using UnityEngine;
using TMPro; 

public class HighScoreManager : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    private int currentScore = 0;
    private int highScore = 0;
    
    // Key để lưu trữ trong registry/file của hệ thống
    private const string HIGHSCORE_KEY = "PlayerHighScore";

    private void Start()
    {
        // 1. Dùng GetInt để đọc dữ liệu khi vừa mở game. Nếu chưa có thì mặc định là 0.
        highScore = PlayerPrefs.GetInt(HIGHSCORE_KEY, 0);
        UpdateUI();
        Debug.Log("Game Started. HighScore loaded: " + highScore);
    }

    private void Update()
    {
        // Bấm phím SPACE để cày điểm
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentScore += 10;
            UpdateUI();
        }

        // Bấm phím S để Lưu điểm (Dùng SetInt)
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveHighScore();
        }

        // Bấm phím R để Xóa điểm (Reset) - Dùng khi bạn muốn quay lại video từ đầu
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteKey(HIGHSCORE_KEY);
            highScore = 0;
            currentScore = 0;
            UpdateUI();
            Debug.Log("Đã xóa HighScore!");
        }
    }

    public void SaveHighScore()
    {
        // Chỉ lưu nếu điểm hiện tại cao hơn kỷ lục cũ
        if (currentScore > highScore)
        {
            highScore = currentScore;
            // 2. Dùng SetInt để lưu giá trị mới
            PlayerPrefs.SetInt(HIGHSCORE_KEY, highScore);
            
            // 3. Bắt buộc gọi Save() để ghi đè xuống ổ cứng
            PlayerPrefs.Save(); 
            
            Debug.Log("Đã lưu kỷ lục mới: " + highScore);
            UpdateUI();
        }
        else
        {
            Debug.Log("Điểm chưa đủ cao để phá kỷ lục.");
        }
    }

    private void UpdateUI()
    {
        if (scoreText != null) scoreText.text = "Score: " + currentScore;
        if (highScoreText != null) highScoreText.text = "High Score: " + highScore;
    }
}