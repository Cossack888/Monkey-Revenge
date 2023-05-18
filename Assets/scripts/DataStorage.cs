using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DataStorage : MonoBehaviour
{
    public GameObject ConversationToStore;
    public GameObject ConversationToStore1;
    public GameObject ConversationToStore2;
    public GameObject ConversationToStore3;
    public GameObject ConversationToStore4;
    public bool wygrana;
    public bool przegrana;
    public GameObject wygranaGra;
    public GameObject przegranaGra;
    public bool GaveString;

    public bool LawfullChoices;
    public bool BadChoices;
    



    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //wygranaGra = GameObject.FindGameObjectWithTag("wygrana");
       // przegranaGra = GameObject.FindGameObjectWithTag("przegrana");
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex == 6)
        {
            if (wygranaGra)
            {
                if (wygranaGra.activeSelf)
                {
                    wygrana = true;
                }
            }
            if (przegranaGra)
            {
                if (przegranaGra.activeSelf)
                {
                    przegrana = true;
                }
            }
        }
        





        if (ConversationToStore)
        {
            if (ConversationToStore.GetComponent<CheckForKeywords>().keyWord2said)
            {
                GaveString = true;

            }
        }
        if (ConversationToStore1)
        {
            if (ConversationToStore1.GetComponent<CheckForKeywords>().keyWord1said)
            {

                LawfullChoices = true;
            }

        }
        if (ConversationToStore2)
        {
            if (ConversationToStore2.GetComponent<CheckForKeywords>().keyWord1said)
            {
                BadChoices = true;

            }
        }
        if (ConversationToStore3)
        {
            if (ConversationToStore3.GetComponent<CheckForKeywords>().keyWord1said)
            {
                BadChoices = true;

            }
        }

        if (ConversationToStore4)
        {
            if (ConversationToStore4.GetComponent<CheckForKeywords>().keyWord1said)
            {
                BadChoices = true;

            }
        }






    }
}
