using UnityEngine;
using System.IO;
using TMPro;

// 1. CLASS LƯU TRỮ DỮ LIỆU (Giống Lab 4)
[System.Serializable]
public class SaveData
{
    public int level;
    public int score;
    public float timePlayed;
}

public class GameSaveManager : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_Text statsText;    // Hiển thị thông số hiện tại
    public TMP_Text statusText;   // Hiển thị thông báo (Đã lưu/Đã tải...)

    // Biến lưu thông số game đang chơi
    private int currentLevel = 1;
    private int currentScore = 0;
    private float currentTimePlayed = 0f;

    private string savePath;

    private void Awake()
    {
        // 2. TẠO ĐƯỜNG DẪN FILE (Giống Lab 6) - Lần này đuôi là .json
        savePath = Application.persistentDataPath + "/miniproject_save.json";
    }

    private void Update()
    {
        // Tự động đếm thời gian chơi
        currentTimePlayed += Time.deltaTime;
        UpdateUI();

        // Nút giả lập chơi game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentScore += 100;
            currentLevel++;
        }

        // Bấm S để Save
        if (Input.GetKeyDown(KeyCode.S)) SaveGame();

        // Bấm L để Load
        if (Input.GetKeyDown(KeyCode.L)) LoadGame();
    }

    public void SaveGame()
    {
        // Bước 1: Đưa dữ liệu hiện tại vào Class SaveData
        SaveData dataToSave = new SaveData
        {
            level = currentLevel,
            score = currentScore,
            timePlayed = currentTimePlayed
        };

        // Bước 2: Ép Class thành chuỗi JSON
        string json = JsonUtility.ToJson(dataToSave, true);

        // Bước 3: Ghi chuỗi JSON xuống ổ cứng
        File.WriteAllText(savePath, json);

        ShowStatus("<color=green>Game Saved!</color>\nFile: " + savePath);
    }

    public void LoadGame()
    {
        if (File.Exists(savePath))
        {
            // Bước 1: Đọc chuỗi JSON từ ổ cứng lên
            string json = File.ReadAllText(savePath);

            // Bước 2: Dịch ngược JSON về lại Class SaveData
            SaveData loadedData = JsonUtility.FromJson<SaveData>(json);

            // Bước 3: Áp dụng dữ liệu vào game
            currentLevel = loadedData.level;
            currentScore = loadedData.score;
            currentTimePlayed = loadedData.timePlayed;

            ShowStatus("<color=cyan>Game Loaded!</color>");
        }
        else
        {
            ShowStatus("<color=red>No save file found!</color>");
        }
    }

    private void UpdateUI()
    {
        if (statsText != null)
        {
            // Cắt thời gian làm tròn 1 chữ số thập phân cho gọn
            statsText.text = $"Level: {currentLevel}\nScore: {currentScore}\nTime Played: {currentTimePlayed:F1}s";
        }
    }

    private void ShowStatus(string message)
    {
        if (statusText != null) statusText.text = message;
        Debug.Log(message);
    }
}