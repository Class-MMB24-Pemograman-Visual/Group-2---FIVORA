using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject Powerup;

    private float zEnemySpawn = 12.0f;
    private float xSpawnBound = 16.0f;
    private float xPowerupRange = 5.0f;
    private float zPowerupRange = 5.0f;
    private float ySpawn = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
        SpawnPowerup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawnBound, xSpawnBound);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xPowerupRange, xPowerupRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(Powerup, spawnPos, Powerup.gameObject.transform.rotation);
    }
}
