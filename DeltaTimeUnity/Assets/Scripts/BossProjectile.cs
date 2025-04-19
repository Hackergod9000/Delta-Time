using UnityEngine;

public class BossProjectile : MonoBehaviour
{
    public float speed = 4f;
    public GameObject explosionPrefab; // Prefab for explosion effect

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            // Call player damage
        }
    }
}