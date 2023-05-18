using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopBalloon : MonoBehaviour
{
    public Component[] hingeJoints;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Shot"))
        {
            GetComponent<Animator>().SetTrigger("Pop");
            GetComponent<BoxCollider2D>().isTrigger = true;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            GetComponent<Rigidbody2D>().gravityScale = 5;
            hingeJoints = GetComponentsInChildren<HingeJoint2D>();
            foreach (HingeJoint2D joint in hingeJoints)
                joint.enabled = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
