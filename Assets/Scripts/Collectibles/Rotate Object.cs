using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    
    public int rotatSpeed =1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatSpeed, 0, Space.World);
        
    }
}
