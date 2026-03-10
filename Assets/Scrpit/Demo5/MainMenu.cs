using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        // Load theo đường dẫn cụ thể vì trong project đang có nhiều scene trùng tên "Battle"
        SceneManager.LoadScene("Assets/Scenes/Demo5/Battle.unity");
    }
}