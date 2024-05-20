using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDownReady;
    public GameObject countDownSet;
    public GameObject countDownRun;
    public GameObject fadeIn;

    void Start()
    {
        StartCoroutine(countSequence());
        
    }
    IEnumerator countSequence() {
        yield return new WaitForSeconds(1.5f);
        countDownReady.SetActive(true);
        yield return new WaitForSeconds(1);
        countDownSet.SetActive(true);
        yield return new WaitForSeconds(1);
        countDownRun.SetActive(true);
        

    }

}
