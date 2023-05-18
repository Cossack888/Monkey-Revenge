using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepCLose : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject leash;
    public float range;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Vector3.Distance(leash.transform.position, transform.position) > range){
            rb.MovePosition(leash.transform.position);


        }
    }
}
