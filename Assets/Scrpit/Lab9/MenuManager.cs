using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameInputField; 

    public void OnPlayButtonClicked()
    {
        CrossSceneData.playerName = nameInputField.text;
        SceneManager.LoadScene("GameScene");
    }
}