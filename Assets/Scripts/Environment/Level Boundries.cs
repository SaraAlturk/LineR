using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundries : MonoBehaviour
{
    // when a variable is static all scripts can interacte with it 
    // thus all scripts can access and modify these boundaries directly using LevelBoundries.leftSide and LevelBoundries.rightSide.
    public static float leftSide = -4.0f;
    public static float rightSide = 4.0f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {
        // This is done so that the boundaries are visible in the Unity Inspector,
        // even though static variables do not appear in the Inspector by default.
        internalLeft = leftSide;
        internalRight = rightSide;

    }
}

