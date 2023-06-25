using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHitChild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Get the parent's script.
        WallHit parentScript = GetComponentInParent<WallHit>();

        // If the parent has the script, call the ChildCollision method.
        if (parentScript != null)
        {
            parentScript.ChildCollision(collision);
        }
    }
}
