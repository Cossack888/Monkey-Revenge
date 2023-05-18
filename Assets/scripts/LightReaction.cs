using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightReaction : MonoBehaviour
{

    public bool alight;
   
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Light")|| collision.CompareTag("Spark") || collision.CompareTag("MegaLight"))
        {
            alight = true;
            gameObject.GetComponent<Animator>().SetBool("Alight",true);
            if (gameObject.GetComponent<LifeManager>()) {
                gameObject.GetComponent<LifeManager>().LightUp();
            }
            

        }
    
    }
    

}
