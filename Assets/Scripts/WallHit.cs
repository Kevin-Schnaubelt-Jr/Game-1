using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHit : MonoBehaviour
{
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
        // Handle the collision.
        Debug.Log("Wall detected a collision with " + collision.gameObject.name);
        // Change the color of the wall by changing the color of children.
        foreach (Transform child in transform)
        {
            child.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
