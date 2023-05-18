using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    Vector3 MousePos;
    [SerializeField] GameObject bulletHole;
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        MousePos.z = 0;

        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(bulletHole, MousePos, transform.rotation);
            
            source.Play();
            Hit();

        }
    }
    private void Hit()
    {
       RaycastHit2D hit = Physics2D.Raycast(transform.position, MousePos);
        Debug.DrawRay(transform.position, MousePos, Color.green);
        if(hit.collider.CompareTag("Enemy")|| hit.collider.CompareTag("NPC"))
        {
            Collider2D[] col = Physics2D.OverlapPointAll(MousePos);

            if (col.Length > 0)
            {
                foreach (Collider2D c in col)
                {
                    if (c != null && !c.CompareTag("Shot"))
                    {
                        if (c.GetComponent<SpriteRenderer>() != null)
                        {
                            c.GetComponent<SpriteRenderer>().enabled = false;
                        }
                        if (c.GetComponent<ParticleSystem>() != null && c.GetComponent<shotReaction>().shot == false)
                        {
                            c.GetComponent<ParticleSystem>().Play();
                            c.GetComponent<shotReaction>().shot = true;

                        }


                    }
                }
            }
        }



        

    }
}
