using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapping : MonoBehaviour
{
    public Transform Target;
    public Transform AI;
    TileScript tileScript;
    public GameObject tilePrefab;
    public GameObject tilePrefab2;
    bool switchBoard = true;
    bool switchBoardFlip = false;
    public int length;
    private int tileCount = 0;
    public GameObject[] Tiles = new GameObject[0];
    // Start is called before the first frame update
    void Start()
    {
        instMap();
    }

    // Update is called once per frame
    void Update()
    {



    }



    void instMap()
    {
        Tiles = new GameObject[length * length];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (switchBoard)
                {
                    Tiles[tileCount] = Instantiate(tilePrefab, new Vector3(j * 1.02f, 0f, i * 1.02f), Quaternion.identity);
                    switchBoard = false;
                }
                else
                {
                    Tiles[tileCount] = Instantiate(tilePrefab2, new Vector3(j * 1.02f, 0f, i * 1.02f), Quaternion.identity);
                    switchBoard = true;
                }
                tileCount++;
            }
            if (length % 2 == 0)
            {
                switchBoard ^= true;
            }

        }

        for (int i = 0; i < length*length; i++)
        {
            //Up
            if(i + length < length*length)
            {
                Tiles[i].GetComponent<TileScript>().up = Tiles[i + length];
            }

            //Down
            if(i - length >= 0)
            {
                Tiles[i].GetComponent<TileScript>().down = Tiles[i - length];
            }

            //Right
            if((i + 1) % length != 0)
            {
                Tiles[i].GetComponent<TileScript>().right = Tiles[i + 1];
            }

            //Left
            if(i % length != 0)
            {
                Tiles[i].GetComponent<TileScript>().left = Tiles[i - 1];
            }

        }





        Target.position = new Vector3(Tiles[length * length - 1].transform.position.x, 1, Tiles[length * length - 1].transform.position.z);


    }
}
