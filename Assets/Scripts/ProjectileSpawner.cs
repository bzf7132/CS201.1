// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the ProjectileSpawner class
public class ProjectileSpawner : MonoBehaviour
{
    // Public variable to store the projectile prefab
    public GameObject enemyProjectile;

    // Variables to control the spawning behavior
    public float spawnTimer;
    public float spawnMax = 5;
    public float spawnMin = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the spawn timer with a random value between spawnMin and spawnMax
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        // Decrease the spawn timer over time
        spawnTimer -= Time.deltaTime;

        // Check if it's time to spawn a projectile
        if (spawnTimer <= 0)
        {
            // Instantiate a projectile at the spawner's position with no rotation
            Instantiate(enemyProjectile, transform.position, Quaternion.identity);

            // Reset the spawn timer with a new random value between spawnMin and spawnMax
            spawnTimer = Random.Range(spawnMin, spawnMax);
        }
    }
}
