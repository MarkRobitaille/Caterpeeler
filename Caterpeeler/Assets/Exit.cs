using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public UnityEngine.UI.Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(delegate { exitGame(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void exitGame()
    {
        Application.Quit();
    }
}
