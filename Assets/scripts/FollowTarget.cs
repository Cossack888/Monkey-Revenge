using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class FollowTarget : MonoBehaviour
{

    public Vector3 MousePos;
    public float speed = 10;
  
    public PlayerMovement movement;
   
    public SpriteRenderer sprite;
    public SpriteRenderer spritePlayer;
    //public Sprite leftFacing;
    //public Sprite rightFacing;
    public GameObject lFPoint;
    public GameObject rFPoint;

    // Start is called before the first frame update
    void Start()
    {
        // MainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        movement = FindObjectOfType<PlayerMovement>();
        sprite = GetComponent<SpriteRenderer>();
        spritePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lFPoint.SetActive(!movement.m_FacingRight);
        rFPoint.SetActive(movement.m_FacingRight);

        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(MousePos.y, MousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (movement.m_FacingRight)
        {
            sprite.flipY = false;
            sprite.sortingOrder = 6;
            


        }
        if (!movement.m_FacingRight)
        {
           
            
            sprite.flipY = true;
            sprite.sortingOrder = 6;
        }

        if (MousePos.x<-0.8|| MousePos.x > 0.8)
        {

            


            if (rotZ < 90 && rotZ > -90 && !movement.m_FacingRight)
            {
                movement.Flip();
                
                // sprite.flipY=false;
            }



            if ((rotZ > 90 && rotZ > -180 || rotZ > -180 && rotZ < -90) && movement.m_FacingRight)
            {
                movement.Flip();
                
                // sprite.flipY = true;
            }

        }




    }
}
