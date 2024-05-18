using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove2 : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing!");
        }
    }

    void Update()
    {
        // Move forward constantly
        Vector3 forwardMovement = Vector3.forward * moveSpeed * Time.deltaTime;

        // Horizontal Movement
        Vector3 horizontalMovement = Vector3.zero;

        // Move left within boundaries
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left key pressed.");
            if (transform.position.x > LevelBoundries.leftSide) // stay within boundary
            {
                horizontalMovement = Vector3.right * leftRightSpeed * Time.deltaTime;
                Debug.Log("Moving Left");
            }
        }

        // Move right within boundaries
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right key pressed.");
            if (transform.position.x < LevelBoundries.rightSide)
            {
                horizontalMovement = Vector3.left * leftRightSpeed * Time.deltaTime;
                Debug.Log("Moving Right");
            }
        }

        // Combine forward and horizontal movements
        Vector3 movement = forwardMovement + horizontalMovement;

        // Move the Rigidbody
        rb.MovePosition(rb.position + movement);
    }
}
