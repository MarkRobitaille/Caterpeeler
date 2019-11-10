using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlayer : MonoBehaviour
{

    public bool hidden;
    // Start is called before the first frame update
    void Start()
    {
        hidden = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hideable")
        {
            hidden = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Hideable")
        {
            hidden = false;
        }
    }
}
