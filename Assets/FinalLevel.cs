using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalLevel : MonoBehaviour
{
    [SerializeField] GameObject[] EnemiesToCheck;
    public int x;
    public int x1;
    public int x2;
    public int x3;
    public int x4;
    public int y;
    GameObject[] InactiveObjects;
    public Scene scene;
    NextLevel nextLevel;

    
   
    // Start is called before the first frame update
    void Start()
    {
        y = EnemiesToCheck.Length;
        nextLevel = GetComponent<NextLevel>();
     



    }

    // Update is called once per frame
    void Update()
    {
        if (EnemiesToCheck.Length == 1)
        {
            if (EnemiesToCheck[0] == null)
            {
                x1 = 1;
            }
        }
        if (EnemiesToCheck.Length == 2)
        {
            if (EnemiesToCheck[0] == null)
            {
                x1 = 1;
            }
            if (EnemiesToCheck[1] == null)
            {
                x2 = 1;
            }
        }

        if (EnemiesToCheck.Length == 3)
        {
            if (EnemiesToCheck[0] == null)
            {
                x1 = 1;
            }
            if (EnemiesToCheck[1] == null)
            {
                x2 = 1;
            }

            if (EnemiesToCheck[2] == null)
            {
                x3 = 1;
            }
        }
        if (EnemiesToCheck.Length == 4)
        {
            if (EnemiesToCheck[0] == null)
            {
                x1 = 1;
            }
            if (EnemiesToCheck[1] == null)
            {
                x2 = 1;
            }

            if (EnemiesToCheck[2] == null)
            {
                x3 = 1;
            }
            if (EnemiesToCheck[3] == null)
            {
                x4 = 1;
            }
        }


        x = x1 + x2 + x3 + x4;


        if (x == y)
        {
           

            nextLevel.LoadNextLevel();

        }
    }

    
}
