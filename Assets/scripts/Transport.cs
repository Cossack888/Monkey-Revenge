using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
    public Transform Pos;
    public GameObject loadingScreen;
    float timer;
    bool timerOn;
    GameObject ObjectToTransport;
    private void Start()
    {
        ObjectToTransport = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        ObjectToTransport = GameObject.FindGameObjectWithTag("Player");
        if (timerOn)
        {
            timer += Time.deltaTime;
        }

        if (timer > 3)
        {
            loadingScreen.SetActive(false);
            ObjectToTransport.transform.position = Pos.position;
            timer = 0;
            timerOn = false;
            
           
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            timerOn=true;
            loadingScreen.SetActive(true);
            
           





        }


    }





}
