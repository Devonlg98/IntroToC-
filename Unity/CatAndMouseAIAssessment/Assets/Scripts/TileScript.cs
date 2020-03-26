using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public float weight = 1;
    public int ID; 
    public bool target = false;
    public int x;
    public int y;
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    public GameObject prev;


    public TileMapping tileMap;
    public Renderer Object; 
    // Start is called before the first frame update
    void Start()
    {
        Object = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("triggerEnter");
        if (collision.gameObject.tag == "mouse")
        {
            target = true;
        }
        Debug.Log("triggerEnter");
        if (collision.gameObject.tag == "cat")
        {
            tileMap.AIpos = ID;
        }

    }


    void OnTriggerExit(Collider collision)
    {
        Debug.Log("triggerExit");
        if (collision.gameObject.tag == "mouse")
        {
            target = false;
        }

    }

    // Update is called once per frame
}
