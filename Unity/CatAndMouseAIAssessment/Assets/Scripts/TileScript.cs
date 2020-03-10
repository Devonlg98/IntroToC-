using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public float weight = 1;
    public int ID; 
    public bool target = false;
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    public GameObject prev;



    public Renderer Object; 
    // Start is called before the first frame update
    void Start()
    {
        Object = GetComponent<Renderer>();
    }

    // Update is called once per frame
}
