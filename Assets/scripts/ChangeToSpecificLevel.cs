using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToSpecificLevel : MonoBehaviour
{
    public GameObject LoadingScreen;
    public float transitionTime = 3f;
    public GameObject changeLevels;
    public DataStorage storage;
    // public GameObject player;
    public int levelnumber;



    void Start()
    {
        storage = FindObjectOfType<DataStorage>();
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");
        //levelnumber = 9;
    }


    // Update is called once per frame
    void Update()
    {

      
        if (changeLevels.activeSelf)
        {
            LoadNextLevel();
            changeLevels.SetActive(false);
        }


    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(levelnumber));
        //player.SetActive(false);
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        LoadingScreen.SetActive(true);
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
