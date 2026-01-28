using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class Lab7_VideoEvents : MonoBehaviour
{
    private VideoPlayer vPlayer;

    void Start()
    {
        Debug.Log("Script Lab7_VideoEvents đã khởi chạy!");
        
        vPlayer = GetComponent<VideoPlayer>();

        if (vPlayer.clip == null && string.IsNullOrEmpty(vPlayer.url))
        {
            Debug.LogError("LỖI: Chưa gán Video Clip vào Video Player!");
            return;
        }

        // 1. Đăng ký sự kiện khi video chuẩn bị xong
        vPlayer.prepareCompleted += OnVideoPrepared;

        // 2. Đăng ký sự kiện khi video chạy hết
        vPlayer.loopPointReached += OnVideoFinished;
        
        Debug.Log("Đang chuẩn bị video...");
        vPlayer.Prepare(); // Bắt đầu load video
    }

    void OnVideoPrepared(VideoPlayer source)
    {
        Debug.Log("Video đã sẵn sàng! Bấm V để xem.");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (!vPlayer.enabled) vPlayer.enabled = true;
            vPlayer.Play();
        }
    }

    void OnGUI()
    {
        // Chỉ hiện nút khi video đang chạy
        if (vPlayer.isPlaying)
        {
            // Tạo Style cho nút to hơn
            GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
            myButtonStyle.fontSize = 25; // Chữ to hơn

            // Vẽ nút ở góc phải màn hình (To gấp đôi: 200x80)
            // Rect(x, y, width, height)
            if (GUI.Button(new Rect(Screen.width - 220, 20, 200, 80), "SKIP VIDEO", myButtonStyle))
            {
                OnVideoFinished(vPlayer);
            }
        }
    }

    void OnVideoFinished(VideoPlayer source)
    {
        Debug.Log("Video đã kết thúc. Tắt video.");
        source.Stop();
        source.enabled = false;
    }
}