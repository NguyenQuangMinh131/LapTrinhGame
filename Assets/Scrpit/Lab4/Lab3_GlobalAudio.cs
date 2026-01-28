using UnityEngine;

public class Lab3_GlobalAudio : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    void Start()
    {
        // Debug.Log("Script Lab3_GlobalAudio đã khởi chạy! Hãy nhớ click vào màn hình Game trước khi bấm phím.");
    }

    void Update()
    {
        // 1. Phím M: Mute/Unmute toàn bộ âm thanh
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            
            // Cách nhanh nhất để Mute toàn bộ là chỉnh volume của AudioListener về 0
            AudioListener.volume = isMuted ? 0f : 1f;
            
            Debug.Log(isMuted ? "Đã tắt tiếng (Mute)" : "Đã bật tiếng (Unmute)");
        }

        // 2. Phím P: Pause/Resume toàn bộ âm thanh
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            
            // AudioListener.pause ảnh hưởng đến tất cả AudioSource trong game
            AudioListener.pause = isPaused;
            
            Debug.Log(isPaused ? "Đã tạm dừng âm thanh" : "Đã tiếp tục âm thanh");
        }
    }
}