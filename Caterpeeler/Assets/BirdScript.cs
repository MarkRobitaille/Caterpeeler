using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BirdScript : MonoBehaviour
{

    public HidePlayer hiddenPlayer;
    public PlayerController playerCont;
    public float startY;
    public float endY;
    public float speed;
    public UnityEvent die;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0f, startY);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(0f, transform.position.y + speed);

        CheckDeath();
    }

    public bool CheckDeath()
    {

        /*if(transform.position.y >= endY)
        {
            if (!hiddenPlayer.hidden)
            {
                Debug.Log("We are here~");
                die.Invoke();
            }
            Debug.Log("After Invoke");

            Destroy(gameObject);

        }*/

        return transform.position.y >= endY;

    }
}
