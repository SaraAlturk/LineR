using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;  
    public GameObject charModel;
    public AudioSource crashHit;
    void OnTriggerEnter(Collider other) {
        crashHit.Play();
      
       this.gameObject.GetComponent<BoxCollider>().enabled = false;
       thePlayer.GetComponent<PlayerMove>().enabled = false;
       charModel.GetComponent<Animator>().Play("Falling");

    }
}
