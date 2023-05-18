using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillAll : MonoBehaviour
{

    GameObject[] Enemies;
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach(GameObject enemy in Enemies)
            {
                if (enemy.GetComponent<EnemyAI>().activated)
                {
                    enemy.tag = "dead";
                }
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in Enemies)
            {
                if (enemy.GetComponent<EnemyAI>().activated)
                {
                    enemy.tag = "dead";
                }
            }
        }
    }






}
