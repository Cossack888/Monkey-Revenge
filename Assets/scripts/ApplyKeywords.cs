using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyKeywords : MonoBehaviour
{
    public GameObject objectWithKeywords;
    public GameObject objecttoActivate1;
    public GameObject objecttoActivate2;
    public GameObject objecttoActivate3;
    public GameObject objecttoActivate4;
    public bool checkObject1;
    public bool checkObject2;
    public bool checkObject3;
    public bool checkObject4;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (objectWithKeywords.GetComponent<CheckForKeywords>().keyWord1said&&checkObject1)
        {
            objecttoActivate1.SetActive(true);
        }
        if (objectWithKeywords.GetComponent<CheckForKeywords>().keyWord2said&&checkObject2)
        {
            objecttoActivate2.SetActive(true);
        }
        if (objectWithKeywords.GetComponent<CheckForKeywords>().keyWord3said&&checkObject3)
        {
            objecttoActivate3.SetActive(true);
        }
        if (objectWithKeywords.GetComponent<CheckForKeywords>().keyWord4said&&checkObject4)
        {
            objecttoActivate4.SetActive(true);
        }
    }
}
    

