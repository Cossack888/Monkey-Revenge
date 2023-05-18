using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiConvo : MonoBehaviour
{
    public GameObject conversation1;
    public GameObject conversation2;
    public GameObject conversation3;
    public GameObject conversation4;
    public GameObject conversation;
    public GameObject ThisTrigger;
    public DialogueManager manager;
    public GameObject dialogueMenu;
    public GameObject camera1;
    public GameObject objectToCheck;
    public GameObject objectToCheck1;
    public GameObject objectToCheck2;
    public bool checkObject1;
    public bool checkObject2;
    public bool checkObject3;
    public bool checkObject4;

    public void Start()
    {


    }

    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")){

            if(objectToCheck1.GetComponent<CheckForKeywords>().keyWord1said|| objectToCheck1.GetComponent<CheckForKeywords>().keyWord2said ||
                objectToCheck1.GetComponent<CheckForKeywords>().keyWord3said || objectToCheck1.GetComponent<CheckForKeywords>().keyWord4said)
            {
                objectToCheck = objectToCheck1;
            }

            if (objectToCheck2.GetComponent<CheckForKeywords>().keyWord1said || objectToCheck2.GetComponent<CheckForKeywords>().keyWord2said ||
                objectToCheck2.GetComponent<CheckForKeywords>().keyWord3said || objectToCheck2.GetComponent<CheckForKeywords>().keyWord4said)
            {
                objectToCheck = objectToCheck2;
            }

            if (objectToCheck)
            {
                if (objectToCheck.GetComponent<CheckForKeywords>().keyWord1said && objectToCheck.GetComponent<CheckForKeywords>().keyWord2said)
                {
                    conversation2.SetActive(true);
                    manager = conversation2.GetComponent<DialogueManager>();
                    conversation = conversation2;
                }
                if (!objectToCheck.GetComponent<CheckForKeywords>().keyWord1said && !objectToCheck.GetComponent<CheckForKeywords>().keyWord2said)
                {
                    conversation2.SetActive(true);
                    manager = conversation2.GetComponent<DialogueManager>();
                    conversation = conversation2;
                }
                else
                {





                    if (objectToCheck.GetComponent<CheckForKeywords>().keyWord1said && checkObject1)
                    {
                        conversation1.SetActive(true);
                        manager = conversation1.GetComponent<DialogueManager>();
                        conversation = conversation1;
                    }
                    if (objectToCheck.GetComponent<CheckForKeywords>().keyWord2said && checkObject2)
                    {
                        conversation2.SetActive(true);
                        manager = conversation2.GetComponent<DialogueManager>();
                        conversation = conversation2;
                    }
                    if (objectToCheck.GetComponent<CheckForKeywords>().keyWord3said && checkObject3)
                    {
                        conversation3.SetActive(true);
                        manager = conversation3.GetComponent<DialogueManager>();
                        conversation = conversation3;
                    }
                    if (objectToCheck.GetComponent<CheckForKeywords>().keyWord4said && checkObject4)
                    {
                        conversation4.SetActive(true);
                        manager = conversation4.GetComponent<DialogueManager>();
                        conversation = conversation4;
                    }


                }

                dialogueMenu.SetActive(true);

            }
            else
            {
                objectToCheck = objectToCheck1;
            }
           

        }
 
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (conversation)
            {
                conversation.SetActive(!manager.finished);
                dialogueMenu.SetActive(!manager.finished);
                camera1.SetActive(true);
            }
            else
            {
                conversation1.SetActive(true);
                manager = conversation1.GetComponent<DialogueManager>();
                conversation = conversation1;
            }

        }

    }


    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            if (conversation)
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






}