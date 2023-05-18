using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeConvoTrigger : MonoBehaviour
{

    public GameObject ConvoTrigger1;
    public GameObject ConvoTrigger2;
    public GameObject ConvoTrigger3;
    public GameObject ConvoTrigger4;
    public GameObject[] NPC;
    public GameObject Convo1;
    public GameObject Convo2;
    public GameObject Convo3;
    public bool ChoiceGood;
    public bool ChoiceBad;
    public bool ChoiceVeryBad;
    public bool NoChoice;






    // Start is called before the first frame update
    void Start()
    {
        NPC = GameObject.FindGameObjectsWithTag("NPC");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
     foreach (GameObject character in NPC)
        {
            if (character==null)
            {
                ConvoTrigger4.SetActive(true);
                ConvoTrigger1.SetActive(false);
                ChoiceVeryBad = true;
            }
            else
            {
               

                if (Convo1.GetComponent<CheckForKeywords>().keyWord1said)
                {
                    ConvoTrigger1.SetActive(true);
                    ChoiceBad = true;
                }

                if (Convo2.GetComponent<CheckForKeywords>().keyWord1said)
                {
                    ConvoTrigger2.SetActive(true);
                    ChoiceGood = true;
                }

                if (Convo2.GetComponent<CheckForKeywords>().keyWord2said)
                {
                    ConvoTrigger3.SetActive(true);
                    NoChoice = true;
                }

                

            }

            



        }  
    }
}
