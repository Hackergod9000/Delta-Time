using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed); // Move the projectile downwards
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the projectile collides with a wall
        if (collision.CompareTag("Boundary"))
        {
            // Destroy the projectile
            Destroy(gameObject);
        }
    }



}
