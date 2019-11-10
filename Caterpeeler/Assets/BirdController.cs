using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    public GameObject birdSign;
    public GameObject bird;

    public PlayerController playerCont;

    public float birdTime;

    public float minRand = -3f;
    public float maxRand = 3f;

    private float nextTime;

    // Start is called before the first frame update
    void Start()
    {
        float randomTime = Random.Range(minRand, maxRand);

        nextTime = birdTime + randomTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextTime)
        {
            birdSign.SetActive(true);
            Instantiate(bird);
            nextTime = Time.time + birdTime;
        }
    }
}
