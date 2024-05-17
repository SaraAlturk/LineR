using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CollectMedKit : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other) {
       
        this.gameObject.SetActive(false);
    }
}
