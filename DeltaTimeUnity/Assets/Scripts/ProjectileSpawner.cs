using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject enemyProjectile; // Prefab of the projectile to be instantiated
    public float spawnTimer;
    public float spawnMax = 3;
    public float spawnMin = 0.3f; // Minimum time between spawns

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax); // Set the initial spawn timer to a random value between spawnMin and spawnMax
        
    }

    // Update is called once per frame
    void Update()
    {
        
        spawnTimer -= Time.deltaTime; // Decrease the spawn timer by the time since the last frame
        if (spawnTimer <= 0)
        {
            Instantiate(enemyProjectile, transform.position, Quaternion.identity); 
            spawnTimer = Random.Range(spawnMin, spawnMax); // Reset the spawn timer to a new random value
        }
    }
}
