using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectLight : MonoBehaviour
{
    public float dir;
    public GameObject lightObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Light"))
        {
            lightObject.SetActive(true);
            transform.rotation = Quaternion.Euler(collision.transform.rotation.x, collision.transform.rotation.y, collision.transform.rotation.z + dir);
        }
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Light"))
        {
            lightObject.SetActive(false);
            
        }


    }

}
