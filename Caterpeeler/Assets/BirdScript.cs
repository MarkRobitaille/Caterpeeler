using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BirdScript : MonoBehaviour
{

    public HidePlayer hiddenPlayer;
    //public PlayerController playerCont;
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

        if(CheckDeath())
        {
            startY = (-1)*Random.Range(400f, 200f);
            transform.position = new Vector2(0f, startY);
        }

    }

    public bool CheckDeath()
    {

        return transform.position.y >= endY;

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && !hiddenPlayer.hidden)
        {
            die.Invoke();
        }
    }
}
