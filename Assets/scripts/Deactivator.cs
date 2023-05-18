using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivator : MonoBehaviour
{ float time = 0;
    public float delay = 3;
    public GameObject lamp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lamp)
        {
            if (lamp.activeSelf)
            {

                time += Time.deltaTime;
                if (time > delay)
                {
                    lamp.GetComponent<SparksActivatior>().shot = false;
                    lamp.SetActive(false);
                    time = 0;
                }

            }
        }
        
    }
}
