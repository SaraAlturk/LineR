using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndRunSequence : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject fadeOut;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndSequence());
        
    }
    IEnumerator EndSequence() {
        yield return new WaitForSeconds(0.5f);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(4);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);

    }
}
 
