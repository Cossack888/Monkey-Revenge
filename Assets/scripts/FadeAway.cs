using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FadeAway : MonoBehaviour
{
    Light2D lightsource;
    float timer;
    public float decreaseAmmount=0.5f;
    public float decreaseTime=0.1f;

    // Start is called before the first frame update
    void Start()
    {
        lightsource = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (lightsource.intensity > 0)
        {
            timer += Time.deltaTime;
            if (timer > decreaseTime)
            {
                lightsource.intensity = lightsource.intensity - decreaseAmmount;
                timer = 0;
            }
        }
        
        
    }
}
