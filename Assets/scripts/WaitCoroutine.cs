using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitCoroutine : MonoBehaviour
{
    public FiringPoint LPoint;
    public FiringPoint RPoint;
    public bool canShoot;
    public float delay;
    public float decrease;
    private void Start()
    {
        canShoot = true;
        
    }

    private void Update()
    {
       
        delay = 0.2f;
    }


    public void StartCoroutine(float delay)
    {
        StartCoroutine(Wait(delay));
    }

    IEnumerator Wait(float time)
    {

        yield return new WaitForSeconds(time);
        canShoot = true;
        
    }
    public void IncreaseSpeed(float speed)
    {
        if (delay > 0.2)
        {
            decrease += speed;
        }
            
        
        
    }
    



}
