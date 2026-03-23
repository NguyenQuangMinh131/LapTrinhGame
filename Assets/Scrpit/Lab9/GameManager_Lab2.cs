using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_Lab2 : MonoBehaviour
{
    public static GameManager_Lab2 Instance;

    public int playerScore = 0; 

    // Thêm biến này để gõ tên Scene muốn chuyển tới trực tiếp trên Inspector
    [Header("Scene Transition")]
    public string targetSceneName = "GameScene"; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    private void Update()
    {
        // Bấm phím Space để nhảy thẳng tới Scene đã chỉ định
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Kiểm tra xem tên Scene có bị bỏ trống không trước khi chuyển
            if (!string.IsNullOrEmpty(targetSceneName))
            {
                SceneManager.LoadScene(targetSceneName);
                Debug.Log("Đang chuyển sang Scene: " + targetSceneName);
            }
            else
            {
                Debug.LogWarning("Bạn chưa nhập tên Scene cần chuyển tới!");
            }
        }
    }
}