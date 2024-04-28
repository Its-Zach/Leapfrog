using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goal : MonoBehaviour
{
    int score = 0;
    public Text scoreText;
    public Text Win;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding GameObject has a specific tag, if needed
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Trigger entered by: " + other.gameObject.name);
            score++;
            scoreText.text = "Score: " + score;
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        if (score == 10)
        {
            Win.text = "Winner!";
            Time.timeScale = 0;
        }
    }
}


