using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    public Vector2 moveDirection;
    public Transform target;
    public Rigidbody2D rb;
    public float moveSpeed = 10f;
    public float dist = 1;
    public float range = 15;
    public bool attackPosition;
    public GameObject player;
    float timer;
    public bool m_FacingRight = true;
    public LifeManager life;
    public bool jump;
    public bool activated;
    public bool groundEnemy;
    public bool stationaryEnemy;
    public bool respawn;
    public float DeathDistance;
    public SpriteRenderer EnemySprite;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        life = GetComponent<LifeManager>();
        Scene scene = SceneManager.GetActiveScene();
        EnemySprite= GetComponent<SpriteRenderer>();
        if (scene.buildIndex == 3)
        {
            // cyrk
            DeathDistance = 30;
        }
        if (scene.buildIndex == 5)
        {
            //kopalnia
            DeathDistance = 30;
        }
        if (scene.buildIndex == 6)
        {
            //lewiatan
            DeathDistance = 100;
        }
       



    }
    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }

        if (respawn)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            
            respawn = false;
        }


        if (player)
        {
            Vector2 direction = (target.position - transform.position).normalized;
            moveDirection = direction;

        }
    }


    private void FixedUpdate()
    {



        if (life)
        {
            if (life.hit == true)
            {
                if (!stationaryEnemy)
                {
                    if (m_FacingRight)
                    {
                        rb.AddForce(Vector2.left * 5, ForceMode2D.Impulse);
                    }
                    if (!m_FacingRight)
                    {
                        rb.AddForce(Vector2.right * 5, ForceMode2D.Impulse);
                    }
                    rb.velocity = Vector2.zero;
                }
                else
                {
                    rb.velocity = Vector2.zero;
                }

            }

        }
       



       
            if (player)
            {
                if (Vector3.Distance(player.transform.position, transform.position) < range)
                {
                    activated = true;
                EnemySprite.color = Color.green;

                }
            if (Vector3.Distance(player.transform.position, transform.position) > DeathDistance && activated == true && gameObject.CompareTag("Enemy"))
                {
                gameObject.tag="dead";


                      }


            if (activated)
                {
                    if (Vector2.Distance(player.transform.position, transform.position) > dist)
                    //&& Mathf.Abs(target.position.x - transform.position.x)<range && Mathf.Abs(target.position.y - transform.position.y) < range))
                    {

                        if (groundEnemy)
                        {
                            if (!stationaryEnemy)
                            {
                                if ((target.position.y - transform.position.y) <= 0)
                                {
                                    rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
                                }
                                if ((target.position.y - transform.position.y) > 0)
                                {
                                    rb.velocity = new Vector2(moveDirection.x, rb.velocity.y) * moveSpeed;
                                }
                            }
                            else
                            {
                                rb.velocity = Vector2.zero;
                            }
                           
                        }
                        else
                        {
                            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
                        }    
                            

                        
                        attackPosition = false;

                        if (rb.velocity.x > 0 && !m_FacingRight)
                        {

                            Flip();

                        }

                        if (rb.velocity.x < 0 && m_FacingRight)
                        {
                            Flip();

                        }

                    }
                    else
                    {
                        rb.velocity = Vector2.zero;

                        attackPosition = true;

                    }
                }
                else
                {
                    rb.velocity = Vector2.zero;

                  

                }
            }
            if (!player)
            {
                rb.velocity = Vector2.zero;

            }


        


    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        transform.Rotate(0f, 180f, 0f);

    }
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(0.5f);
        jump = false;

    }

    public void AfterRespawn()
    {
        Debug.Log("ActivateAfterResp");
        player = GameObject.FindGameObjectWithTag("Player");
        target = GameObject.FindGameObjectWithTag("Player").transform;
        respawn = true;
        
       
    }


}
