using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        // If the object collides with the player, change the color to red
        if (other.gameObject.name == "John Tutorial (Player)")
        {
            Debug.Log("Object Hit!");
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
