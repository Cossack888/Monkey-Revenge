using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    bool timerOn;
    float timer;
    [SerializeField] float delay = 2;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
    
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<LifeManager>().TakeDamage(50);
        }
    }

    
    void TrapDamage(int dmg)
    {
        Player.GetComponent<LifeManager>().TakeDamage(dmg);
    }

}
