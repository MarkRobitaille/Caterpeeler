using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeScript : MonoBehaviour
{
    public UnityEngine.UI.Button button;
    public GameObject objectToDeactivate;

    void Start()
    {
        button.onClick.AddListener(delegate { DeactiveObject(objectToDeactivate); });
    }

    void DeactiveObject(GameObject go)
    {
       objectToDeactivate.SetActive(false);
    }
}
