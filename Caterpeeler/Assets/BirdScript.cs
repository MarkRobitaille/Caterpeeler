using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public HidePlayer hiddenPlayer;
    public PlayerController playerCont;
    public float startY;
    public float endY;
    public float speed;

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

    private void CheckDeath()
    {

        if(transform.position.y >= endY)
        {
            if (!hiddenPlayer.hidden)
            {
                playerCont.Die();
            }
            Debug.Log("We are here");

            Destroy(gameObject);

        }

    }
}
