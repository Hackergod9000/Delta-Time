using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player movement
    public float hInput; // Horizontal input value

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal"); // Get horizontal input (A/D or Left/Right Arrow keys)

        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed * hInput); // Move the player based on input and speed
    }
}
