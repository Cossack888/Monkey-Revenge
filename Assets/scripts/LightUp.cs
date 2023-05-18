using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);

        }
        if (collision.gameObject.CompareTag("NPC"))
        {
            collision.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1);

        }
    }

}
