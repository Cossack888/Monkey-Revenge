using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    public bool enlightement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spark") || collision.CompareTag("Light"))
        {
            enlightement = true;
            
        }

        if (collision.CompareTag("MegaLight"))
        {
            enlightement = true;

            gameObject.GetComponent<LifeManager>().TakeDamage(150);


        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Spark")||collision.CompareTag("Light"))
        {
            enlightement = true;
            
        }

       

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Spark")|| collision.CompareTag("Light")|| collision.CompareTag("MegaLight"))
        {
            enlightement = true;
            StartCoroutine(Wait());
        }
    }



    IEnumerator Wait()
    {

        yield return new WaitForSeconds(5f);
        enlightement = false;

    }



}
