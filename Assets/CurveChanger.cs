using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveChanger : MonoBehaviour
{
    public Material[] myMaterials;


    private float currentValue;
    private float targetValue;

    public float lerpTime;

    private bool isComplete = true;


    private void Start()
    {
        foreach (Material material in myMaterials)
        {
            currentValue = material.GetFloat("_Sideways_Strength");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Curve"))
        {

            if (isComplete)
            {
                StartCoroutine(changeCurveStrength());
            }

        }
    }


    public IEnumerator changeCurveStrength()
    {
        float elapsedTime = 0;
        targetValue = Random.Range(-.005f, .005f);

        while (elapsedTime < lerpTime)
        {
            isComplete = false;

            currentValue = Mathf.Lerp(currentValue, targetValue, elapsedTime / lerpTime);
            elapsedTime += Time.deltaTime;


            foreach (Material material in myMaterials)
            {
                material.SetFloat("_Sideways_Strength", currentValue);
            }


            yield return null;

        }

        isComplete = true;
        currentValue = targetValue;

    }


}
