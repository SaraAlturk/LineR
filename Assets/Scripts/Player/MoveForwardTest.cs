using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardTest : MonoBehaviour
{
    public float moveSpeed = 3;

    // Update is called once per frame
    void Update()
    {
        // Move forward constantly z axis is forward backwards is a negative 
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        
    }
}
