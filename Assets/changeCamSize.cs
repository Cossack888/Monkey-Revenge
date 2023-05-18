using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCamSize : MonoBehaviour
{
    [SerializeField] float aspectRatioDesign = (16f / 9f);
    [SerializeField] float orthographicStartSize = 3.8f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        OnGUI();
    }

    private void OnGUI()
    {
        

        float inverseAspectRatio = 1 / aspectRatioDesign;
        float currentAspectRatio = (float)Screen.width / (float)Screen.height;

        if (currentAspectRatio > aspectRatioDesign)
        {
            currentAspectRatio -= (currentAspectRatio - aspectRatioDesign);
        }
        else if (currentAspectRatio < inverseAspectRatio)
        {
            currentAspectRatio += (currentAspectRatio - inverseAspectRatio);
        }

        Camera.main.orthographicSize = aspectRatioDesign * (orthographicStartSize / currentAspectRatio);
    }
}
