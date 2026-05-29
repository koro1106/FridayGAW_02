using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float spawnRadius = 10f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // プレイヤー周辺にランダムスポーン
        Vector3 spawnPos = Random.insideUnitSphere * spawnRadius;
        spawnPos.y = 0; // 地面に合わせる

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}