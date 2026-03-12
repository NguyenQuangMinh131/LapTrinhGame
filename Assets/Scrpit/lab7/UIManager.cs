using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Kéo SettingsPanel vào ô này trong Inspector
    public GameObject settingsPanel; 

    public void StartGame() { Debug.Log("Start!"); }
    public void ExitGame() { Application.Quit(); }

    public void OpenOptions()
    {
        settingsPanel.SetActive(true); // Hiển thị bảng Settings
    }

    public void CloseOptions()
    {
        settingsPanel.SetActive(false); // Ẩn bảng Settings đi (Gắn hàm này vào một nút "X" trong SettingsPanel)
    }
}