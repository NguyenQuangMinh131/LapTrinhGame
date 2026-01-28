using UnityEngine;

public class Lab1_AudioTrigger : MonoBehaviour
{
    private AudioSource myAudio;

    void Start()
    {
        // Lấy thành phần AudioSource gắn trên cùng Object
        myAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Nhấn Space để Play
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAudio.Play();
            Debug.Log("Đang chạy âm thanh...");
        }

        // Nhấn S để Stop
        if (Input.GetKeyDown(KeyCode.S))
        {
            myAudio.Stop();
            Debug.Log("Đã dừng âm thanh.");
        }
    }
}