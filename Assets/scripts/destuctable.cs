using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destuctable : MonoBehaviour
{
    bool timerOn;
    float timer;
    [SerializeField] float delay=2;
    
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
        if (collision.gameObject.CompareTag("Shot"))
        {
            timerOn = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 10;
        }
    }
}
