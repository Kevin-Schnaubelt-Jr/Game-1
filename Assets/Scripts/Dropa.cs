using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropa : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float dropaTime = 3f;
    bool enableStatement = true;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log($"It was been {Time.time} seconds since the game started.");
        if (Time.time > dropaTime && enableStatement == true)
        {
            enableStatement = false;
            Debug.Log($"{dropaTime} seconds has elapsed. Dropin time!");
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
