using UnityEngine;
using UnityEngine.UI; 

public class HealthUI : MonoBehaviour
{
    [Header("References")]
    public PlayerHealth playerHealth; // Kéo Player vào đây
    public Text statusText;           // Kéo UI Text vào đây

    void OnEnable()
    {
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged += UpdateHealth;
            playerHealth.OnPlayerDeath += HandleGameOver;
        }
    }

    void OnDisable()
    {
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged -= UpdateHealth;
            playerHealth.OnPlayerDeath -= HandleGameOver;
        }
    }

    void UpdateHealth(int hp)
    {
        statusText.text = "HP: " + hp;
        statusText.color = Color.white; 
    }

    void HandleGameOver()
    {
        statusText.text = "GAME OVER";
        statusText.color = Color.red; 
    }
}