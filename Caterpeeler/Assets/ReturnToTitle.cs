using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToTitle : MonoBehaviour
{

    public float displayTime = 4; // ms?
    public string titleScreenScene = "TitleScreen";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("CREATING WIN SCREEN");
        StartCoroutine(LoadTitleScreen(displayTime));

    }

    IEnumerator LoadTitleScreen(float displayTime)
    {
        Debug.Log("I AM LOADING THE TITLE SCREEN");
        yield return new WaitForSeconds(displayTime);
        SceneManager.LoadScene(titleScreenScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
