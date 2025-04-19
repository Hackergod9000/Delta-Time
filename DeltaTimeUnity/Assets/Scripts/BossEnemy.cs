using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    public int maxHealth = 50;
    private int currentHealth;

    //public float moveSpeed = 2f;
    public GameObject bossProjectile;
    public float fireInterval = 2f;
    public GameObject explosionPrefab; // Prefab for explosion effect

    private float fireTimer;
    private PointManager pointManager; // Reference to the PointManager script
     public GameObject gamewonPanel;

    void Start()
    {
        currentHealth = maxHealth;
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>(); // Find the PointManager in the scene
    }

    void Update()
    {
    //    Move();
        //HandleFiring();
    }

    // void Move()
    // {
    //     transform.position += Vector3.right * Mathf.Sin(Time.time) * moveSpeed * Time.deltaTime;
    // }

    // void HandleFiring()
    // {
    //     fireTimer += Time.deltaTime;
    //     if (fireTimer >= fireInterval)
    //     {
    //         // Instantiate(bossProjectile, transform.position, Quaternion.identity);
    //         // fireTimer = 0f;
    //     }
    // }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            pointManager.UpdateScore(500);
            Die();
            gamewonPanel.SetActive(true);
            Time.timeScale = 0;
            
        }
    }

    void Die()
    {
        // You can play explosion, give score, etc.
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            TakeDamage(1); // Or get damage from bullet
            Destroy(collision.gameObject);
        }
    }
}