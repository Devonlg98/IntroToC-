using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetChange : MonoBehaviour
{

    public TileScript tileScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void OnTriggerEnter(Collider collision)
    //{
    //    Debug.Log("triggerEnter");
    //    if (collision.gameObject.tag == "tile")
    //    {
    //        collision.
    //        collision.gameObject.tag = "target";
    //    }

    //}

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("triggerEnter");
        if (collision.gameObject.tag == "tile")
        {

            tileScript.target = false;
        }

    }
}
