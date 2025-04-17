using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float moveSpeed;
    public GameObject explosionPrefab; // Prefab for explosion effect
    private PointManager pointManager; // Reference to the PointManager script

    // Start is called before the first frame update
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>(); // Find the PointManager in the scene
    }

    // Update is called once per frame
    void Update()
    {
        // Move the projectile forward in the direction it is facing
        transform.Translate(Vector2.up * Time.deltaTime * moveSpeed); 
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the projectile collides with an enemy
        if (collision.CompareTag("Enemy"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity); // Create explosion effect
            Destroy(collision.gameObject);
            pointManager.UpdateScore(50); // Update the score in the PointManager
            Destroy(gameObject);
        }
        // Check if the projectile collides with a wall
        else if (collision.CompareTag("Boundary"))
        {
            // Destroy the projectile
            Destroy(gameObject);
        }
    }
}
