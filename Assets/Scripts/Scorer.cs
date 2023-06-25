using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Current Score: {score}");
    }

    void OnCollisionEnter(Collision other)
    {
        // Score a point every time the player collides with anything except the Plane Object.
        if (other.gameObject.name != "Plane" && other.gameObject.tag != "Hit" && !gameOver)
        {
            other.gameObject.tag = "Hit";
            score++;
            Debug.Log($"Current Score: {score}");
        }
    }

    private void OnTriggerEnter(Collider other) 
    {

        // If the player hits tiggers the goal, disable scoring and print a message.
        if (other.gameObject.name == "Finish")
        {
            gameOver = true;
            if (score == 1)
            {
                Debug.Log($"You scored {score} point! That's Par!");
            }
            else if (score < 1)
            {
                Debug.Log($"You scored {score} points! PERFECT SCORE!");
            }
            else
            {
                Debug.Log($"Congratulations! You scored {score} points!");
            }
        }
    }
}
