using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFromChain : MonoBehaviour
{
    public Sprite freedFromChain;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Shot"))
        {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 10;
            gameObject.GetComponent<SpriteRenderer>().sprite = freedFromChain;
        }
    }
}
