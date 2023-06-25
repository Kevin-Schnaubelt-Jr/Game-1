using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // This variable enables the if statement
    bool enableStatement = true;
    private void OnCollisionEnter(Collision other) 
    {
        // If the object collides with the player, change the color to red
        if (other.gameObject.tag == "Player" && enableStatement)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log($"You hit a {transform.parent.name}!");
            enableStatement = false;
        }
    }
}
