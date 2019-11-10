using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BirdController : MonoBehaviour
{

    public GameObject birdSign;
    public GameObject bird;

    private BirdScript birdScript;
    public PlayerController playerCont;
    public HidePlayer hiddenPlayer;
    public UnityEvent die;

    private GameObject currBird;

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
            currBird = Instantiate(bird);
            birdScript = currBird.GetComponent<BirdScript>();
            nextTime = Time.time + birdTime;
        }

        CheckDeath();
    }

    private void CheckDeath()
    {
        if (currBird != null && birdScript.CheckDeath())
        {
            if (!hiddenPlayer.hidden)
            {
                Debug.Log("We are here~");
                die.Invoke();
            }
            Debug.Log("After Invoke");

            Destroy(currBird);

        }
    }
}
