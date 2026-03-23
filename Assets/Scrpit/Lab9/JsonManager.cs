using UnityEngine;
using TMPro; // Nhớ dùng TMP cho UI đẹp nhé

// 1. CLASS DỮ LIỆU: BẮT BUỘC phải có [System.Serializable] ở ngay trên đầu
// Nếu thiếu dòng này, Unity sẽ không biết cách chuyển đổi class này
[System.Serializable]
public class PlayerData
{
    public string playerName;
    public int level;
    public float health;
    public string[] inventory; // Một mảng để thấy JSON lợi hại thế nào
}

public class JsonManager : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_Text jsonDisplayText; // Chỗ hiển thị chuỗi JSON
    public TMP_Text resultText;      // Chỗ hiển thị kết quả dịch ngược

    private string currentJsonString = "";

    void Update()
    {
        // Phím J: Chuyển C# Object -> chuỗi JSON
        if (Input.GetKeyDown(KeyCode.J))
        {
            SerializeToJson();
        }

        // Phím L: Chuyển chuỗi JSON -> C# Object
        if (Input.GetKeyDown(KeyCode.L))
        {
            DeserializeFromJson();
        }
    }

    void SerializeToJson()
    {
        // 1. Tạo một Object dữ liệu mẫu
        PlayerData myData = new PlayerData();
        myData.playerName = "Knight_01";
        myData.level = 15;
        myData.health = 250.5f;
        myData.inventory = new string[] { "Kiếm gỗ", "Bình máu x5" };

        // 2. Chuyển Object thành chuỗi JSON
        // Tham số 'true' ở cuối gọi là "Pretty Print" - giúp JSON tự xuống dòng, thụt lề cho dễ đọc
        currentJsonString = JsonUtility.ToJson(myData, true);
        
        // 3. Hiển thị lên UI
        if (jsonDisplayText != null)
        {
            jsonDisplayText.text = "Chuỗi JSON tạo ra:\n" + currentJsonString;
        }
        Debug.Log("Đã tạo JSON!");
    }

    void DeserializeFromJson()
    {
        if (string.IsNullOrEmpty(currentJsonString))
        {
            Debug.LogWarning("Chưa có chuỗi JSON!");
            return;
        }

        // 4. Dịch ngược chuỗi JSON trở lại thành C# Object
        PlayerData loadedData = JsonUtility.FromJson<PlayerData>(currentJsonString);

        // 5. Hiển thị lên UI để chứng minh ta đã lấy lại được dữ liệu
        if (resultText != null)
        {
            resultText.text = $"Dịch ngược thành công!\nTên: {loadedData.playerName}\nCấp: {loadedData.level}\nItem 1: {loadedData.inventory[0]}";
        }
        Debug.Log("Đã dịch ngược JSON!");
    }
}