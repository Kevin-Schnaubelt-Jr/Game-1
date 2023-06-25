using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpinner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When triggered, reveal the trap.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Find the trap.
            GameObject Trap = GameObject.Find("Spinner (2)");
            // Enable the mesh renderer.
            Trap.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
