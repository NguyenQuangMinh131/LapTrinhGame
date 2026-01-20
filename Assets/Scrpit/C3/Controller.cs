using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("Gán Object đang có trên Scene vào đây")]
    public GameObject targetObject; 

    [Header("Gán Prefab vào đây để test tạo mới")]
    public GameObject objectPrefab; 

    void Update()
    {
        // 1. Phím A: Toggle Active (Bật/Tắt)
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (targetObject != null)
            {
                bool isActive = targetObject.activeSelf;
                targetObject.SetActive(!isActive);
            }
            else
            {
                Debug.LogWarning("Object đã bị hủy, không thể Bật/Tắt được nữa!");
            }
        }

        // 2. Phím D: Destroy (Hủy object)
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (targetObject != null)
            {
                Destroy(targetObject);
            }
        }

        // 3. Phím S: Spawn (Tạo mới)
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (objectPrefab != null)
            {
                // Tạo ra object mới tại vị trí ngẫu nhiên để dễ nhìn
                Vector3 randomPos = new Vector3(Random.Range(-2f, 2f), 2, 0);
                GameObject newObj = Instantiate(objectPrefab, randomPos, Quaternion.identity);
                
                // Gán object mới tạo vào biến targetObject để mình có thể Destroy nó tiếp
                targetObject = newObj;
                
            }
        }
    }
}