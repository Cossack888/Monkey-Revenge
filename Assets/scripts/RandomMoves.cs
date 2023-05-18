using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoves : MonoBehaviour
{

    public EnemyAI AI;
    public Rigidbody2D rb;
    float timer;
    float delay=1;
    // Start is called before the first frame update
    void Start()
    {
        AI = GetComponent<EnemyAI>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AI.activated)
        {
            timer += Time.deltaTime;
            if (timer > delay)
            {
                rb.AddForce(new Vector2(Random.Range(-1, 2), Random.Range(-1, 2)) * 200, ForceMode2D.Impulse);
                timer = 0;
            }


        }


    }
}
