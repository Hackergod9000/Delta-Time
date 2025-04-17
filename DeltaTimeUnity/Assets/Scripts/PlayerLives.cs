using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import the UI namespace to use UI elements

public class PlayerLives : MonoBehaviour
{
    public int lives = 3; 
    public Image[] livesUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collides with an enemy
        if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.collider.gameObject); // Destroy the enemy object
           lives -= 1; // Decrease the player's lives by 1
           for(int i = 0; i < livesUI.Length; i++)
           {
               if(i < lives)
               {
                   livesUI[i].enabled = true; // Enable the life icon
               }
               else
               {
                   livesUI[i].enabled = false; // Disable the life icon
               }
           }
           if(lives <= 0)
           {
               // If the player has no lives left, destroy the player object
               Destroy(gameObject);
           }
           
        }
    }
}
