using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import the TextMeshPro namespace to use TextMeshPro elements

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText; // Reference to the TextMeshPro text element

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + 0.ToString(); // Initialize the score text to 0
    }

    public void UpdateScore(int points)
    {
        score += points; // Increase the score by the specified points
        scoreText.text = "Score: " + score.ToString(); // Update the score text
    }
}
