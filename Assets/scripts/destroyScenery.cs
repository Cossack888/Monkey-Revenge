using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyScenery : MonoBehaviour
{
    BoxCollider2D boxCollider;
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Shot"))
        {
            boxCollider.enabled = false;
            sprite.color = new Color(0, 0, 0, 1);
        }
    }
   

}
