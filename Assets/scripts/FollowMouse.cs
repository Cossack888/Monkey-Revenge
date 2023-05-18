using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    PlayerMovement move;
    Vector3 MousePos;

    private void Start()
    {
        move = FindObjectOfType<PlayerMovement>();
    }
    void Update()
    {
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(MousePos.y, MousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
        if (rotZ != 0|| rotZ != -180)
        {

           


            if (rotZ < 90 && rotZ > -90 && !move.m_FacingRight)
            {
                move.Flip();
                // sprite.flipY=false;
            }



            if ((rotZ > 90 && rotZ > -180 || rotZ > -180 && rotZ < -90) && move.m_FacingRight)
            {
                move.Flip();
                // sprite.flipY = true;
            }

        }
        if (rotZ == 0 || rotZ == -180)
        {
            Debug.Log("null");
        }




    }





}
