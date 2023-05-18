using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScreen : MonoBehaviour
{
    public GameObject changeLevel;

    private void Start()
    {
        StartCoroutine("Timeout2");
    }


    IEnumerator Timeout2()
    {

        yield return new WaitForSeconds(5);
        changeLevel.SetActive(true);

    }
}
