using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeting : MonoBehaviour
{
    GameObject target;
    Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            targetPos = target.transform.position - transform.position;
            float rotZ = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotZ);
        }
    }
}
