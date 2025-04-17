using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab of the projectile to be instantiated

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) // Check if the fire button (left mouse button or Ctrl) is pressed
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity); // Instantiate the projectile at the player's position with no rotation
        }
    }
}
