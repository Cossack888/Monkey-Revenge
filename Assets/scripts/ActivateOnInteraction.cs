using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnInteraction : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject objectToActivate2;
    [SerializeField] GameObject objectToDeactivate;
    [SerializeField] GameObject objectToAnimate;
    public bool Activator1;
    public bool Activator2;
    public bool Deactivator;
    public bool AnimatingObject;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
                if (Activator1)
                {
                    objectToActivate.SetActive(true);
                }
            if (Activator2)
            {
                objectToActivate2.SetActive(true);
            }
            if (Deactivator)
                {
                    objectToDeactivate.SetActive(false);
                }
                if (AnimatingObject)
                {
                objectToAnimate.GetComponent<Animator>().SetTrigger("Activate");
                }


            GetComponent<ActivateOnInteraction>().enabled = false;
            



            
        }


    }

}
