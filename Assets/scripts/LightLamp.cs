using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightLamp : MonoBehaviour
{

    Light2D lamp;
    CircleCollider2D cc;
    float timer;
    bool timerOn;
    private void Start()
    {
        lamp = GetComponent<Light2D>();
        cc = GetComponent<CircleCollider2D>();
        lamp.intensity = 1;
        cc.enabled = false;
    }

    private void Update()
    {
        if (timerOn)
        {
            timer += Time.deltaTime;

            if (timer > 10)
            {
                lamp.intensity = 1;
                cc.enabled = false;
                timer = 0;
                timerOn = false;
            }
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("lightBullet"))
        {
            lamp.intensity=4;
            cc.enabled = true;
            timerOn=true;
            timer = 0;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("lightBullet"))
        {
            lamp.intensity = 4;
            cc.enabled = true;
            timerOn = true;
            timer = 0;

        }




    }




}
