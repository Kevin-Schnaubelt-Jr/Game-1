using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDrop1 : MonoBehaviour
{
    // Variable to store game object FallObstacle.
    GameObject FallObstacle;
    // On collision with the player, enable meshrender and rigidbody for FallObstacle.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FallObstacle = GameObject.Find("FallObstacle (1)");
            FallObstacle.GetComponent<MeshRenderer>().enabled = true;
            FallObstacle.GetComponent<Rigidbody>().useGravity = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
