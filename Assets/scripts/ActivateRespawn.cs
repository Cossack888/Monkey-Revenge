using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRespawn : MonoBehaviour
{
    GameObject[] respawnPoints;
    public GameObject deathScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        respawnPoints = GameObject.FindGameObjectsWithTag("resPoint");
        
       
    }

    public void Respawn()
    {
        if (respawnPoints.Length == 1)
        {
            respawnPoints[0].GetComponent<Respawn>().RespawnMode();
        }
        deathScreen.SetActive(false);


    }
}
