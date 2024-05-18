using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;
    public float jumpForce = 1f;  // Add a jump force
    private bool isGrounded = true;  // To check if the player is grounded
    private Rigidbody rb;  // Reference to the Rigidbody component

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component
        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing!");
        }
    }

    void Update()
    {
        // Move forward constantly z axis is forward backwards is a negative 
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        // Move left within boundaries
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            if (this.gameObject.transform.position.x > LevelBoundries.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }

        // Move right within boundaries
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            if (this.gameObject.transform.position.x < LevelBoundries.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
            }
        }

        // Jump if the space key is pressed and the player is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("Space key pressed and player is grounded. Jumping...");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;  // Set isGrounded to false after jumping
        }
    }

    // Check if the player is grounded using collision detection
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))  // Assuming the ground has the tag "Ground"
        {
            Debug.Log("Player has collided with the ground.");
            isGrounded = true;  // Set isGrounded to true when colliding with the ground
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))  // Assuming the ground has the tag "Ground"
        {
            Debug.Log("Player has left the ground.");
            isGrounded = false;  // Set isGrounded to false when leaving the ground
        }
    }

}
