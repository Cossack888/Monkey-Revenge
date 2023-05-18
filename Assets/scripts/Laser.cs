using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{   private Vector3 MousePos;
    private LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        MousePos.z = 0;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, MousePos);
       
            if (hit.collider)
        {
            lr.SetPosition(1, MousePos);
        }

    }
}
