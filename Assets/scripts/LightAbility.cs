using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightAbility : MonoBehaviour
{
    public Light2D lightsource;
    
    public GameObject megaLight;
    public float timer;
    public float delay = 2;
    public bool defence;
    public float increase=0;
    // Start is called before the first frame update
    void Start()
    {
       
        lightsource.intensity = 0.1f;
        lightsource.pointLightOuterRadius = 1;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameObject.CompareTag("dead"))
        {
            if (Input.GetMouseButtonDown(2))
            {

                lightsource.intensity=1+increase;
                lightsource.pointLightOuterRadius = 1 + increase;
               // StartCoroutine("Timeout2");
                defence = true;

            }
            if (Input.GetMouseButton(2))
            {


                timer += Time.deltaTime;

                


                if (timer > delay)
                {
                    Instantiate(megaLight, transform.position, transform.rotation,gameObject.transform);
                    timer = 0;
                    defence = true;
                    StartCoroutine(Wait());
                }

            }


            if (Input.GetMouseButtonUp(2))
            {

                lightsource.intensity=0.1f;
               
                defence = false;
                timer = 0;
            }
        }
    }
   

    public void LightPowerUp(float inc)
    {
        increase += inc;
    }

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(delay+0.2f+increase);
        defence = false;

    }
    

}
