using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RevolverBullet : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float speed=40;
    private Vector3 MousePos;
    private float timer;
    public float delay;
    public int damage = 50;
    public int ZappPower = 100;
    public GameObject idleGun;

    private void Start()
    {
        idleGun = GameObject.FindGameObjectWithTag("IdleGun");
        if (idleGun)
        {
            rb.velocity = new Vector2(0,2) * speed;
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else
        {
            MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rb = GetComponent<Rigidbody2D>();
            Vector3 direction = MousePos - transform.position;

            MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float rotZ = Mathf.Atan2(MousePos.y, MousePos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotZ);
            rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
        }
        

        

    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            Destroy(gameObject);
            timer = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mirron"))
        {
            if (collision.gameObject.GetComponent<ParticleSystem>() != null)
            {
                collision.gameObject.GetComponent<ParticleSystem>().Play();

            }
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("NPC"))
        {

            if (collision.gameObject.GetComponent<ParticleSystem>() != null)
            {
                collision.gameObject.GetComponent<ParticleSystem>().Play();

            }
            /* if (collision.gameObject.GetComponent<BoxCollider2D>() != null)
             {
                 collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
             }/*/
            if (gameObject.CompareTag("Shot"))
            {
                if (collision.gameObject.GetComponent<LifeManager>() != null)
                {
                    collision.gameObject.GetComponent<LifeManager>().TakeDamage(50);
                }
            }
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy") )
        {
            
            if (collision.gameObject.GetComponent<ParticleSystem>() != null)
            {
                collision.gameObject.GetComponent<ParticleSystem>().Play();

            }
            
            if (gameObject.CompareTag("Shot"))
            {
                if (collision.gameObject.GetComponent<LifeManager>() != null)
                {
                    collision.gameObject.GetComponent<LifeManager>().TakeDamage(50);
                }
            }



            Destroy(gameObject);
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Mirron")){
            if (collision.gameObject.GetComponent<ParticleSystem>() != null)
            {
                collision.gameObject.GetComponent<ParticleSystem>().Play();

            }
        }
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("NPC"))
        {
           /* if (collision.gameObject.GetComponent<SpriteRenderer>() != null)
            {
                collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }*/
            if (collision.gameObject.GetComponent<ParticleSystem>() != null )
            {
                collision.gameObject.GetComponent<ParticleSystem>().Play();
                
            }
            /* if (collision.gameObject.GetComponent<BoxCollider2D>() != null)
             {
                 collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
             }/*/
            if (gameObject.CompareTag("Shot"))
            {
                if (collision.gameObject.GetComponent<LifeManager>() != null)
                {
                    collision.gameObject.GetComponent<LifeManager>().TakeDamage(50);
                }
            }
            


            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("dead"))
        {

            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("metalBox"))
        {
            
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y).normalized * speed;
        }

        if (collision.gameObject.CompareTag("Ground"))
        {

            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Light"))
        {

            if (collision.gameObject.GetComponentInChildren<LampActivation>() != null)
            {
                collision.gameObject.GetComponentInChildren<LampActivation>().lamp.SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}

