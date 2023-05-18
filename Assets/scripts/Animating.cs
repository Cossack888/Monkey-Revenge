using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animating : MonoBehaviour
{
    EnemyAI AI;
    Animator anim;
    public float timer;
    bool attack;
    GameObject player;
    public LifeManager life;
    // Start is called before the first frame update
    void Start()
    {
        AI = GetComponent<EnemyAI>();
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        life = GetComponent<LifeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            if (Mathf.Abs(AI.rb.velocity.x) >= 0.5f && attack == false)
            {
                anim.SetFloat("Speed", Mathf.Abs(AI.rb.velocity.x));
            }



            if (Mathf.Abs(AI.rb.velocity.x) < 0.5f)
            {
                anim.SetFloat("Speed", 0);
                timer += Time.deltaTime;
                if (timer > 1)
                {
                    attack = true;
                    anim.SetTrigger("Attack");
                    StartCoroutine(Wait());

                    timer = 0;
                }
            }
        }
        if (!player)
        {
            anim.SetFloat("Speed", 0);
        }
        if (life.hit == true)
        {
            anim.SetFloat("Speed", 0);
            anim.SetTrigger("isShot");
        }

    }
    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(1.0f);
        attack = false;
        
    }
}
