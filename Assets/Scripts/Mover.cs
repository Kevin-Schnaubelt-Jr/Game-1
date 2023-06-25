using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float wasdSpeed = 20f;
    [SerializeField] float flightSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
        Debug.Log("Par score is 1");
    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * wasdSpeed;
        float yValue = Input.GetAxis("Jump") * Time.deltaTime * flightSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * wasdSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}
