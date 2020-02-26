using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public float weight; 
    public float ID; 
    public bool target = false;
    public float x;
    public float y;
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    public GameObject prev;



    public Renderer Object; 
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        Object = GetComponent<Renderer>();
    }

    // Update is called once per frame
}
