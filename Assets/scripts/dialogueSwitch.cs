using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueSwitch : MonoBehaviour
{
    public GameObject convo;
    string textNow;
    public GameObject gun;
    public GameObject textWindow;
    public Image leftImage;
    public Image rightImage;
    public Sprite spriteLeft;
    public Sprite spriteRight;
    public Sprite JD;
    public Sprite Revolver;
    public Sprite Grajek;
    public Sprite Wartownik;
    public Sprite Klaun;
    public Sprite Mirron;
    public Sprite Priest;
    public Sprite Bride;
    public Sprite Narrator;
    public Sprite Placeholder;



    // Start is called before the first frame update
    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("PlayerGun");
        leftImage.sprite = JD;
        rightImage.sprite = Placeholder;
    }

    // Update is called once per frame
    void Update()
    {
        gun = GameObject.FindGameObjectWithTag("PlayerGun");

        if (convo)
        {
            if (gun)
            {
                if (convo.activeSelf)
                {
                    gun.SetActive(false);
                }
                if (!convo.activeSelf)
                {
                    gun.SetActive(true);

                }
            }
        }
        

        if (convo = GameObject.FindGameObjectWithTag("Conversation"))
        {
            
            convo = GameObject.FindGameObjectWithTag("Conversation");
            
            textNow = convo.GetComponent<DialogueManager>().CurrentText;
            
            
           

            if (textNow.Contains("LUSTERKOLT:"))
            {
                
                rightImage.sprite = Revolver;
                textWindow.GetComponent<Image>().sprite = spriteRight;
            }
            if (textNow.Contains("MIRRON:"))
            {
                
               rightImage.sprite = Mirron;
                textWindow.GetComponent<Image>().sprite = spriteRight;
            }
            if (textNow.Contains("STARY KATZ:"))
            {

                rightImage.sprite = Grajek;
                textWindow.GetComponent<Image>().sprite = spriteRight;
            }
            if (textNow.Contains("WARTOWNIK:"))
            {
                textWindow.GetComponent<Image>().sprite = spriteRight;
                rightImage.sprite = Wartownik;
            }
            if (textNow.Contains("PATSY:"))
            {
                textWindow.GetComponent<Image>().sprite = spriteRight;
                rightImage.sprite = Bride;
            }
            if (textNow.Contains("PASTOR:"))
            {
                textWindow.GetComponent<Image>().sprite = spriteRight;
                rightImage.sprite = Priest;
            }

            if (textNow.Contains("NARRATOR:"))
            {
                textWindow.GetComponent<Image>().sprite = spriteRight;
                rightImage.sprite = Narrator;
            }
            else
            {
                textWindow.GetComponent<Image>().sprite = spriteLeft;
                
            }




            
        }
        
    }
}
