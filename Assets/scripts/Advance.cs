using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Advance : MonoBehaviour
{
    
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject objectToActivate1;
    [SerializeField] GameObject objectToDeactivate;
    public bool Activator1;
    public bool Activator2;
    public bool Deactivator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("dead"))
        {
            if (Activator1)
            {
                objectToActivate.SetActive(true);
                
            }
            if (Activator2)
            {
                objectToActivate1.SetActive(true);
                
            }
            if (Deactivator)
            {
                
                objectToDeactivate.SetActive(false);
            }

        }
    }
}
