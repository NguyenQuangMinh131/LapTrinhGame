using UnityEngine;

// Dòng này giúp tạo ra một menu khi click chuột phải trong tab Project
[CreateAssetMenu(fileName = "NewGameConfig", menuName = "Lab Data/Game Config")]
public class GameConfig : ScriptableObject
{
    [Header("Player Settings")]
    public int startingHealth = 100;
    public float baseMoveSpeed = 5.5f;
    public string difficulty = "Normal";
}