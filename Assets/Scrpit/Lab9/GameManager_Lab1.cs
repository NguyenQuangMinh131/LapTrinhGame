using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager_Lab1 : MonoBehaviour
{
    public TMP_Text playerNameDisplay; 

    private void Start()
    {
        playerNameDisplay.text = "Welcome, " + CrossSceneData.playerName + "!";
    }
}