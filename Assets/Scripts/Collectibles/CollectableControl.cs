using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Import TextMeshPro namespace

public class CollectableControl : MonoBehaviour
{
    public static int coinCount = 0;
    public TMP_Text coinCountDisplay;  // Use TMP_Text for TextMeshPro


    void Start()
    {
        // Initialize the coin count display
        if (coinCountDisplay != null)
        {
            coinCountDisplay.text = coinCount.ToString();

        }
        else
        {
            Debug.LogError("Coin count display not assigned!");
        }
    }

    void Update()
    {
        // Update the coin count display
        if (coinCountDisplay != null)
        {
            coinCountDisplay.text = coinCount.ToString();
  
        }
    }
}
