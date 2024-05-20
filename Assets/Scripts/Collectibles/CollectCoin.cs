using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFx;
    void OnTriggerEnter(Collider other) {

        coinFx.Play();
        CollectableControl.coinCount +=1;
        this.gameObject.SetActive(false);
    }
}
