using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSelfActivate : MonoBehaviour
{
    //public GameObject objectToActivate;
    public GameObject[] InactiveObjects;
    // Start is called before the first frame update
    void Start()
    { InactiveObjects = FindObjectsOfType<GameObject>(true);
        foreach (GameObject objectToActivate in InactiveObjects)
        {
            if (objectToActivate.CompareTag("przegrana"))
            {
                objectToActivate.SetActive(true);
            }
        }

       
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
}
