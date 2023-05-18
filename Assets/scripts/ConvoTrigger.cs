using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvoTrigger : MonoBehaviour
{
    public GameObject conversation;
    public GameObject ThisTrigger;
    public DialogueManager manager;
    public GameObject dialogueMenu;
    public GameObject camera1;
    public GameObject[] Enemies;
    public bool InBattle;

    public void Start()
    {
       

    }

    private void Update()
    {
        Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (Enemies.Length == 0)
        {
            InBattle = false;
        }
        foreach(GameObject enemy in Enemies)
        {
            if (enemy.GetComponent<EnemyAI>())
            {
                if (enemy.GetComponent<EnemyAI>().activated)
                {
                    InBattle = true;
                }
                if (enemy.GetComponent<EnemyAI>().activated==false)
                {
                    InBattle = false;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && manager.finished == false &&!InBattle)
        {
            dialogueMenu.SetActive(true);
            conversation.SetActive(true);


        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&&!InBattle){
            conversation.SetActive(!manager.finished);
            dialogueMenu.SetActive(!manager.finished);
            camera1.SetActive(true);
        }
        if (InBattle)
        {
            conversation.SetActive(false);
            dialogueMenu.SetActive(false);
            camera1.SetActive(false);
        }
        
    }


    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            conversation.SetActive(false);
            dialogueMenu.SetActive(false);
            camera1.SetActive(false);

            if (manager.finished == true)
            {

                ThisTrigger.SetActive(false);
                
            }
        }

    }






}