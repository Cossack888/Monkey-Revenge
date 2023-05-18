using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitualAdvancement : MonoBehaviour
{
    public GameObject obrecz;
    public GameObject narrator;
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(gameObject.CompareTag("dead"))
        {

            StartCoroutine("Timeout2");
            GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
                foreach(GameObject Enemy in Enemies)
            {
                Enemy.tag = "dead";
            }



        }
    }


    IEnumerator Timeout2()
    {

        yield return new WaitForSeconds(1);
        obrecz.GetComponent<Animator>().SetBool("alight", true);
        obrecz.GetComponent<BoxCollider2D>().enabled = true;
        narrator.SetActive(true);
        menu.SetActive(true);
    }
}
