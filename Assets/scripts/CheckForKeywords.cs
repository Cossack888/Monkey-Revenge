using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForKeywords : MonoBehaviour
{
    public string textNow;
    public string keyWord1;
    public string keyWord2;
    public string keyWord3;
    public string keyWord4;
    public bool keyWord1said;
    public bool keyWord2said;
    public bool keyWord3said;
    public bool keyWord4said;
    public GameObject Conversation;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Conversation)
        {
            textNow = Conversation.GetComponent<DialogueManager>().CurrentText;
            if (textNow.Contains(keyWord1))
            {
                keyWord1said = true;

            }
            if (textNow.Contains(keyWord2))
            {
                keyWord2said = true;

            }
            if (textNow.Contains(keyWord3))
            {
                keyWord3said = true;

            }
            if (textNow.Contains(keyWord4))
            {
                keyWord4said = true;

            }
        }
        





    }


    
}
