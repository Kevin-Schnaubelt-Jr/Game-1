using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDrop2 : MonoBehaviour
{
    // Variable to store game object FallObstacle.
    GameObject FallObstacle1;
    GameObject FallObstacle2;
    GameObject FallObstacle3;
    // On collision with the player, enable meshrender and rigidbody for FallObstacle.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FallObstacle1 = GameObject.Find("PeskyBugga (1)");
            MakeAppear(FallObstacle1);
            FallObstacle2 = GameObject.Find("PeskyBugga (2)");
            MakeAppear(FallObstacle2);
            FallObstacle3 = GameObject.Find("PeskyBugga (3)");
            MakeAppear(FallObstacle3);
        }
    }

    void MakeAppear(GameObject FallObstacle)
    {
        FallObstacle.GetComponent<MeshRenderer>().enabled = true;
        FallObstacle.GetComponent<Rigidbody>().useGravity = true;
    }
}
