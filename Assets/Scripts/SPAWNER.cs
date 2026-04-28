using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // ZOMBIE prefab
    public GameObject zombiePrefab;

    // Assign your SPHERE object here (spawn area)
    public Transform spawnSphere;

    // How big the sphere is
    public float radius = 5f;

    // Timer
    public float spawnDelay = 5f;
    private float timer;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnMultipleEnemies();
            timer = spawnDelay;
        }
    }

    void SpawnRandomEnemy()
    {
        // Random point inside a sphere
        Vector3 randomPoint = Random.insideUnitSphere * radius;

        // Offset by sphere position
        Vector3 spawnPos = spawnSphere.position + randomPoint;

        Instantiate(zombiePrefab, spawnPos, Quaternion.identity);
    }

    // Spawn 3 zombies
    void SpawnMultipleEnemies()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnRandomEnemy();
        }
    }
}