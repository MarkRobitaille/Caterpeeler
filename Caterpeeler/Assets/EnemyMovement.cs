using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public PlayerController player;
    private Transform playerLocation;
    public float speed;
    public float viewDistance;

    // Start is called before the first frame update
    void Start()
    {
        playerLocation = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerLocation!=null)
        {
            
            float distance = Vector2.Distance(transform.position, playerLocation.position);

            if (distance<viewDistance)
            {
                //Debug.Log("DEBUG: MOVE TOWARDS");
                transform.position = Vector2.MoveTowards(transform.position, playerLocation.position, speed * Time.deltaTime);
            } else
            {
                //Debug.Log("DEBUG: NOT IN RANGE");
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player") ;
        {
            //Debug.Log("Hit the Enemy");
            Destroy(col.gameObject);
        }

    }
}
