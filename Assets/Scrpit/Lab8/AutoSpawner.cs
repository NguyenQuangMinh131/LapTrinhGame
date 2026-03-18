using UnityEngine;

public class AutoSpawner : MonoBehaviour
{
    [Header("Danh sách các loại quái vật (Kéo Prefab vào đây)")]
    public GameObject[] enemyPrefabs; 

    [Header("Thời gian giữa 2 lần spawn (giây)")]
    public float spawnInterval = 3f;

    private float timer = 0f; 

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnRandomEnemy();
            timer = 0f; 
        }
    }

    void SpawnRandomEnemy()
    {
        if (enemyPrefabs.Length == 0)
        {
            Debug.LogWarning("Chưa có quái vật nào trong danh sách!");
            return;
        }

        int randomIndex = Random.Range(0, enemyPrefabs.Length);

        GameObject selectedEnemy = enemyPrefabs[randomIndex];

        Instantiate(selectedEnemy, transform.position, Quaternion.identity);
    }
}