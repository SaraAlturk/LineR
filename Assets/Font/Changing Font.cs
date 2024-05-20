using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangingFont : MonoBehaviour
{
   public TMP_Text textMeshProComponent;
    public TMP_FontAsset newFont;

    void Start()
    {
        if (textMeshProComponent != null && newFont != null)
        {
            textMeshProComponent.font = newFont;
        }
        else
        {
            Debug.LogError("TextMeshPro component or new Font Asset is not assigned.");
        }
    }
}