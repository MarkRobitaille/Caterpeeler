using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToDifferentScene : MonoBehaviour
{
    public bool changeImmediately = false;
    public float displayTime = 4; // In seconds?
    public string sceneName = "TitleScreen"; // Default to title screen

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("CREATING WIN SCREEN");
        if (changeImmediately)
        {
            SceneManager.LoadScene(sceneName);
        } else
        {
            StartCoroutine(LoadDifferentScene(displayTime));
        }
        

    }

    IEnumerator LoadDifferentScene(float displayTime)
    {
        Debug.Log("I AM LOADING THE TITLE SCREEN");
        yield return new WaitForSeconds(displayTime);
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
