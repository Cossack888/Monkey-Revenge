using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public SparksActivatior sparksActivatior;
    Vector2 aim;
    public float speed=10;

    private void Start()
    {
        sparksActivatior = FindObjectOfType<SparksActivatior>();
        
    }

    private void FixedUpdate()
    {
        
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, aim, step);

    }
    public void PickTarget(Vector2 target)
    {

        aim = target;
    }
}
