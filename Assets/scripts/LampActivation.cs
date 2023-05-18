using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampActivation : MonoBehaviour
{
    public GameObject lamp;
   
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("lightBullet"))
        {
            lamp.SetActive(true);
            if (lamp.activeSelf)
            {
                lamp.GetComponent<SparksActivatior>().shot = false;
            }

        }
    }




}
