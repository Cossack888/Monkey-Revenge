using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnShot : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject objectToDeactivate;
    public bool Activator;
    public bool Deactivator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shot")||collision.gameObject.CompareTag("lightBullet"))
        {
            if (Activator)
            {
                objectToActivate.SetActive(true);
            }
            if (Deactivator)
            {
                objectToDeactivate.SetActive(false);
            }
            Destroy(gameObject);
        }


    }

}
