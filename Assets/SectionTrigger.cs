using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{

    public GameObject roadSection;

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(roadSection, new Vector3(0, 0, -35), Quaternion.identity);
        }
    }

}
