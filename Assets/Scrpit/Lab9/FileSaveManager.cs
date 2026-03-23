using UnityEngine;
using System.IO; // BẮT BUỘC phải có thư viện này để thao tác với File
using TMPro;

public class FileSaveManager : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_InputField inputField; // Chỗ để gõ chữ
    public TMP_Text displayText;      // Chỗ hiển thị chữ tải lên

    private string savePath;

    private void Awake()
    {
        // Tạo đường dẫn tới file save.txt nằm trong thư mục an toàn của game
        savePath = Application.persistentDataPath + "/my_save_file.txt";
        Debug.Log("Đường dẫn lưu file: " + savePath);
    }

    private void Update()
    {
        // Bấm phím S để Lưu file
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveToFile();
        }

        // Bấm phím L để Đọc file
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadFromFile();
        }
    }

    public void SaveToFile()
    {
        string dataToSave = inputField.text;
        
        // Ghi toàn bộ nội dung vào file (nếu chưa có file thì nó tự tạo mới)
        File.WriteAllText(savePath, dataToSave);
        
        Debug.Log("<color=green>Đã lưu file thành công tại:</color> " + savePath);
    }

    public void LoadFromFile()
    {
        // Kiểm tra xem file có tồn tại không trước khi đọc
        if (File.Exists(savePath))
        {
            string loadedData = File.ReadAllText(savePath);
            if (displayText != null)
            {
                displayText.text = "Dữ liệu từ file:\n" + loadedData;
            }
            Debug.Log("<color=cyan>Đã tải file thành công!</color>");
        }
        else
        {
            Debug.LogWarning("Không tìm thấy file save nào!");
        }
    }
}