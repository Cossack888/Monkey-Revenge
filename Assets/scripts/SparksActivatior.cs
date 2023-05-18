using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparksActivatior : MonoBehaviour
{
    public Vector2 target;
    public Vector3 aim;
    SparksActivatior sparks;
    List<GameObject> listOfTargets;
    public GameObject[] sparkObjects;
    public GameObject sparkObject;
    public int ammountOfSparks;
    public bool shot;

    private void Start()
    {

        listOfTargets = new List<GameObject>();
        ammountOfSparks = 0;

    }
    private void Update()
    {
       
        if (gameObject.activeSelf&&shot==false)
            
        {
            
            GameObject[] LightPoints = GameObject.FindGameObjectsWithTag("Target");
            sparkObjects = GameObject.FindGameObjectsWithTag("Spark");

            foreach (GameObject LightPoint in LightPoints)
            {
                listOfTargets.Add(LightPoint);
            }
            if (sparkObjects.Length < 6)
            {
                switch (ammountOfSparks)
                {
                    case 0:
                        target = listOfTargets[0].transform.position;
                        Instantiate(sparkObject, transform.position, transform.rotation);
                        sparkObjects = GameObject.FindGameObjectsWithTag("Spark");
                        sparkObjects[0].GetComponent<Chase>().PickTarget(target);
                        ammountOfSparks++;
                        break;
                    case 1:
                        target = listOfTargets[1].transform.position;
                        Instantiate(sparkObject, transform.position, transform.rotation);
                        sparkObjects = GameObject.FindGameObjectsWithTag("Spark");
                        sparkObjects[1].GetComponent<Chase>().PickTarget(target);
                        ammountOfSparks++;
                        break;
                    case 2:
                        target = listOfTargets[2].transform.position;
                        Instantiate(sparkObject, transform.position, transform.rotation);
                        sparkObjects = GameObject.FindGameObjectsWithTag("Spark");
                        sparkObjects[2].GetComponent<Chase>().PickTarget(target);
                        ammountOfSparks++;
                        break;
                    case 3:
                        target = listOfTargets[3].transform.position;
                        Instantiate(sparkObject, transform.position, transform.rotation);
                        sparkObjects = GameObject.FindGameObjectsWithTag("Spark");
                        sparkObjects[3].GetComponent<Chase>().PickTarget(target);
                        ammountOfSparks++;
                        break;
                    case 4:
                        target = listOfTargets[4].transform.position;
                        Instantiate(sparkObject, transform.position, transform.rotation);
                        sparkObjects = GameObject.FindGameObjectsWithTag("Spark");
                        sparkObjects[4].GetComponent<Chase>().PickTarget(target);
                        ammountOfSparks++;
                        break;
                    case 5:
                        sparkObjects = null;
                        shot = true;
                        ammountOfSparks = 0;
                        break;
                    default:

                        return;
                }
            }
            else
            {
                foreach (GameObject spark in sparkObjects)
                {
                    Destroy(spark);
                    ammountOfSparks = 0;

                }
            }


          





        }



        
       


    }

    

   
}
