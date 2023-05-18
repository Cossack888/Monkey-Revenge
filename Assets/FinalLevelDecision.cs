using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalLevelDecision : MonoBehaviour
{
    public Scene DominacjaJD;
    public Scene DominacjaWartownik;
    public Scene Integracja;
    public GameObject PierwszeZakonczenie;
    public GameObject DrugieZakonczenie;
    public GameObject   TrzecieZakonczenie;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PierwszeZakonczenie.activeSelf)
        {
           
                SceneManager.LoadScene(8);
            
        }
        if (DrugieZakonczenie.activeSelf)
        {

            SceneManager.LoadScene(9);

        }
        if (TrzecieZakonczenie.activeSelf)
        {

            SceneManager.LoadScene(10);

        }
    }
}
