using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class Lab5_Video : MonoBehaviour 
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        
        // Kiểm tra xem đã có video để phát chưa
        if (videoPlayer.clip == null && string.IsNullOrEmpty(videoPlayer.url))
        {
            Debug.LogError("LỖI: Bạn chưa gán Video Clip vào component Video Player!");
        }

        // Tắt Play On Awake để kiểm soát bằng phím V
        videoPlayer.playOnAwake = false;
    }

    void Update() {
        // Nhấn V để Play
        if (Input.GetKeyDown(KeyCode.V)) 
        {
            if (videoPlayer.isPlaying)
            {
                Debug.Log("Video đang chạy rồi!");
            }
            else
            {
                videoPlayer.Play();
                Debug.Log("Đã bấm V -> Đang phát Video...");
            }
        }
    }
}