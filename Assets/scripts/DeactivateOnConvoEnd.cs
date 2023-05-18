using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateOnConvoEnd : MonoBehaviour
{
    public GameObject objectToCheck;
    public GameObject objectToCheck1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objectToCheck.GetComponent<CheckForKeywords>().keyWord1said)
        {
            Destroy(gameObject);
        }

        if (objectToCheck1.GetComponent<CheckForKeywords>().keyWord1said)
        {
            Destroy(gameObject);
        }
    }
}
