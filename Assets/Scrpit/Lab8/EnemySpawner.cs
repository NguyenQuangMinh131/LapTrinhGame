using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Kéo thả Enemy Prefab vào đây")]
    public GameObject enemyPrefab;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}