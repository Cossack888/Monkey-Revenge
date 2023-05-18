using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndConvo : MonoBehaviour
{
    public GameObject convo;
    string textNow;
    public GameObject menu;
   

    // Update is called once per frame
    void Update()
    {



        if (convo = GameObject.FindGameObjectWithTag("Conversation"))
        {

            convo = GameObject.FindGameObjectWithTag("Conversation");

            textNow = convo.GetComponent<DialogueManager>().CurrentText;

            if (textNow.Contains("Zakoñcz"))
            {
                convo.SetActive(false);
                menu.SetActive(false);
            }

        }

    }


    public void EraseMenu()
    {
convo.SetActive(false);
                menu.SetActive(false);
    }
}
