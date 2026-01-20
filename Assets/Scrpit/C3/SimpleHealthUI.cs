using UnityEngine;
using UnityEngine.UI;

public class SimpleHealthUI : MonoBehaviour
{
    public Text hpText; // Kéo Text vào đây

    public void UpdateHP(int hp)
    {
        hpText.text = "Health: " + hp;
        
        if (hp <= 30) hpText.color = Color.red;
        else hpText.color = Color.green;
    }

    // Hàm xử lý Game Over
    public void ShowGameOver()
    {
        hpText.text = "YOU DIED";
        hpText.color = Color.yellow;
    }
}