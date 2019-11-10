using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeActiveGameObject : MonoBehaviour
{
    public float displayTime = 2;
    public GameObject newObj;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeGameObject(displayTime));
    }

    IEnumerator ChangeGameObject(float displayTime)
    {
        Debug.Log("CHANGING TO ZERO HEALTH SOON");
        yield return new WaitForSeconds(displayTime);

        Debug.Log("CHANGING TO ZERO HEALTH");
        gameObject.SetActive(false);
        newObj.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
