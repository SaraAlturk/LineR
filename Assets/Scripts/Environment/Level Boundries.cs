using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundries : MonoBehaviour
{
    // when its static all scripts can interacte with it 
    public static float leftSide = -1.4f;
    public static float rightSide = 2.3f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {
        // when a var is static it doesn't appera in panel so we did this so its visiable in inspecter
        internalLeft = leftSide;
        internalRight = rightSide;

    }
}
