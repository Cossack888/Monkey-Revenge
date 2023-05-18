using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDataStorage : MonoBehaviour
{
    public DataStorage storage;
    public GameObject LawfullWin;
    public GameObject LawfullLoose;
    public GameObject ChaoticWin;
    public GameObject ChaoticLoose;

    public void Start()
    {
        storage = FindObjectOfType<DataStorage>();
    }

    

    void Update()
    {
        if (storage)
        {
            if (storage.LawfullChoices && storage.wygrana)
            {
                LawfullWin.SetActive(true);
            }
            if (storage.LawfullChoices && storage.przegrana)
            {
                LawfullLoose.SetActive(true);
            }


            if (storage.BadChoices && storage.wygrana)
            {
                ChaoticWin.SetActive(true);
            }
            if (storage.BadChoices && storage.przegrana)
            {
                ChaoticLoose.SetActive(true);
            }
        }
       




    }


}
