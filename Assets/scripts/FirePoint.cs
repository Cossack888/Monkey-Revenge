using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject lightBullet;
    [SerializeField] private LayerMask m_WhatIsGround;
    AudioSource source;
    [SerializeField]
    AudioClip[] clips;
    EnemyAI AI;
    public bool shotfired;
    public float timer;
    public float delay;
    GameObject player;
    void Start()
    {
        source = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");
        AI = GetComponentInParent<EnemyAI>();
    }

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }



    private void FixedUpdate()
    {
        
        if (player)
        {
            if (AI.activated)
            {
                RaycastHit2D[] hits;
                hits = Physics2D.RaycastAll(transform.position, player.transform.position-transform.position, Vector3.Distance(player.transform.position, transform.position), m_WhatIsGround);
                Debug.DrawRay(transform.position, player.transform.position-transform.position);
                for (int i = 0; i < hits.Length; i++)
                {
                    
                    RaycastHit2D hit2 = hits[0];
                  

                    if ( timer > delay && shotfired == false)
                    { 

                        if (!hit2.collider.CompareTag("Ground")&& !hit2.collider.CompareTag("Enemy"))
                        {
                            
                            Instantiate(bullet, transform.position, transform.rotation);
                            ChangeTheSound(0);
                            shotfired = true;
                            StartCoroutine(Wait());
                            timer = 0;
                        }
                            

                    }

                }
                timer += Time.deltaTime;              
            }
            
                
           
           

        }

    }

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(1f);
        shotfired = false;

    }


    public void AfterRespawn()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
      
    }
    public void ChangeTheSound(int clipIndex) // the index of the sound, 0 for first sound, 1 for the 2nd..etc
    {
        // use one desired logic
        // this will make only one sound to play without interruption
        source.clip = clips[clipIndex];
        source.Play();

        // this will make multiple sound to play with interruption
        // source.PlayOneShot(clips[clipIndex]);
    }
}

