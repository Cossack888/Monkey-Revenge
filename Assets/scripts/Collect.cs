using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Collect : MonoBehaviour
{
    bool timerOn;
    float timer;
    [SerializeField] float delay = 2;
    public LifeControl control;
    public LightAbility ability;
    public WaitCoroutine coroutine;
    public void Start()
    {
        control = FindObjectOfType<LifeControl>();
        ability = FindObjectOfType<LightAbility>();
        coroutine = FindObjectOfType<WaitCoroutine>();
    }

    void Update()
    {
        if (timerOn)
        {
            timer += Time.deltaTime;
        }
        if (timer > delay)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Shot"))
        {

            if (gameObject.GetComponent<BoxCollider2D>())
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            if (gameObject.GetComponent<CircleCollider2D>())
            {
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
            }
            if (gameObject.GetComponent<SpriteRenderer>())
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
            if (gameObject.GetComponent<Rigidbody2D>())
            {
                gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 10;
            }
            




        }

        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("LifePowerUp"))
            {
                control.AddLife();
            }
            if (gameObject.CompareTag("LightPowerUp"))
            {
                ability.LightPowerUp(0.2f);
            }
            if (gameObject.CompareTag("SpeedPowerUp"))
            {
                coroutine.IncreaseSpeed(0.3f);
            }

            Destroy(gameObject);
            
        }

    }



}
