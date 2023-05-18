using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{ GameObject DataStorage;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        DataStorage = GameObject.FindGameObjectWithTag("DataStorage");
    }
    // Update is called once per frame
    void Update()
    {
        if (DataStorage)
        {
            gameObject.transform.parent = DataStorage.transform;
        }
    }
}
