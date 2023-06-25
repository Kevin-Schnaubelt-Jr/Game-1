using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHit : MonoBehaviour
{

    // This variable enables the if statement
    bool enableStatement = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChildCollision(Collision collision)
    {
        // If the object collides with the player, change children.
        if (collision.gameObject.tag == "Player" && enableStatement)
        {
            Debug.Log($"You hit the Frame!");
            // Change the color and tag of all children.
            foreach (Transform child in transform)
            {
                child.gameObject.tag = "Hit";
                child.GetComponent<MeshRenderer>().material.color = Color.red;
            }
            enableStatement = false;
        }
    }
}
