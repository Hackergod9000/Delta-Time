using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    public GameObject bossPrefab;
    public Transform bossSpawnPoint;
    private bool bossSpawned = false;

    void Update()
    {
        //  // Log the time for debugging
        // if (!bossSpawned &&  Time.realtimeSinceStartupAsDouble > 30) // Or any condition
        // {
        //     Instantiate(bossPrefab, bossSpawnPoint.position, Quaternion.identity);
        //     bossSpawned = true;
        // }
    }
}