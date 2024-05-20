using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 23;
    public bool creatingSection = false;
    public int secNum;


    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false) {
            creatingSection = true;
            StartCoroutine(GenerateSection());


        }
        
    }
    IEnumerator GenerateSection() {
        secNum = Random.Range(0,3);
        // duplicating func.
        Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity);
        zPos +=23;

        //time for re-generating the section 
        yield return new WaitForSeconds(1.5f);
        creatingSection = false;
    }
}
