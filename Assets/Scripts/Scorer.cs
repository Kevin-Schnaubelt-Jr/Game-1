using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score: " + score);
    }

    void OnCollisionEnter(Collision other) 
    {
        // Score a point every time the player collides with anything except the Plane Object.
        if (other.gameObject.name != "Plane")
        {
            Debug.Log("Point Get!");
            score++;
            Debug.Log($"Score: {score}");
        }
    }
}
