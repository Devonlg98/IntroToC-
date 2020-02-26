using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapping : MonoBehaviour
{
    public Transform Target;
    public Transform AI;
    public float AIx;
    public float AIy;
    public int AIpos;
    public int targetPos;

    private int foundPos;



    public float whileLoopBreaker = 0;
    public TileScript tileScript;
    public GameObject tilePrefab;
    bool switchBoard = true;
    bool switchBoardFlip = false;
    bool foundTarget = false;
    public int length;
    private int tileCount = 0;
    public List<int> unvisited = new List<int>();
    public List<int> visited = new List<int>();
    public List<int> closed = new List<int>();
    public List<GameObject> targetPath = new List<GameObject>();
    public Material materialvisited;
    public Material materialclosed;

    bool shmovin;


    public GameObject[] Tiles = new GameObject[0];
    //public GameObject[] pathTargets = new GameObject[0];
    // Start is called before the first frame update
    void Start()
    {
        tileScript.Object = GetComponent<Renderer>();
        instMap();
        //AIx = AI.position.x;
        //AIy = AI.position.y;

        if(AIpos < 0 || AIpos >= length*length)
        {
            AIpos = 0;
        }
        AI.position = matchPosition(AIpos);
        visited.Add(AIpos);
        Target.position = matchPosition(targetPos);
        Tiles[targetPos].GetComponent<TileScript>().target = true;
    }

    // Update is called once per frame
    void Update()
    {

        while (unvisited.Count > 1 && foundTarget == false)
        {
            //Tiles[visited[0]].GetComponent<TileScript>().Object.material = materialvisited;
            surroundingCheck(visited[0]);           
            whileLoopBreaker++;
        }

        if (foundTarget == true)
        {
            GameObject temp = Tiles[0];
            while (Tiles.GetComponent<TileScript>().prev == true)
            {
                for (int i = 0; i < Tiles.Length - 1; i++)
                {
                    targetPath.Add(temp.GetComponent<TileScript>().prev);
                    temp = temp.GetComponent<TileScript>().prev;
                }
                targetPath.Reverse();
            }

        }




    }



    void instMap()
    {

        Tiles = new GameObject[length * length];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            { 
                Tiles[tileCount] = Instantiate(tilePrefab, new Vector3(j * 1.02f, 0f, i * 1.02f), Quaternion.identity);
                Tiles[tileCount].name = "Tile " + tileCount;
                Tiles[tileCount].GetComponent<TileScript>().ID = tileCount;
                tileCount++;
                unvisited.Add(i*length+j);
            }
            
        }

        for (int i = 0; i < length*length; i++)
        {
            TileScript tile = Tiles[i].GetComponent<TileScript>();

            //Up
            if (i + length < length*length)
            {
                tile.up = Tiles[i + length];
            }

            //Right
            if ((i + 1) % length != 0)
            {
                tile.right = Tiles[i + 1];
            }

            //Down
            if(i - length >= 0)
            {
                tile.down = Tiles[i - length];
            }
            
            //Left
            if (i % length != 0)
            {
                tile.left = Tiles[i - 1];
            }

        }
    }


    Vector3 matchPosition (int desiredPos)
    {
        return new Vector3(Tiles[desiredPos].transform.position.x, 1, Tiles[desiredPos].transform.position.z);
    }

    void surroundingCheck(int checkPos)
    {
        Tiles[visited[0]].GetComponent<TileScript>().Object.material = materialclosed;
        visited.RemoveAt(0);
        closed.Add(checkPos);
        TileScript checkedTile = Tiles[checkPos].GetComponent<TileScript>();
        
        //Up
        if (checkedTile.up == true && !(visited.Contains(checkPos + length)) && !(closed.Contains(checkPos + length)))
        {
            Debug.Log(checkPos + length);
            visited.Add(checkPos + length);
            Tiles[checkPos + length].GetComponent<TileScript>().Object.material = materialvisited;
            Tiles[checkPos + length].GetComponent<TileScript>().prev = Tiles[checkPos];
            unvisited.Remove(checkPos + length);
            if(Tiles[checkPos + length].GetComponent<TileScript>().target == true)
            {
                foundPos = checkPos + length;
                foundTarget = true;
                return;
            }
        }

        //Right
        if (checkedTile.right == true && !(visited.Contains(checkPos + 1)) && !(closed.Contains(checkPos +1 )))
        {
            Debug.Log(checkPos + 1);
            visited.Add(checkPos + 1);
            Tiles[checkPos + 1].GetComponent<TileScript>().Object.material = materialvisited;
            Tiles[checkPos + 1].GetComponent<TileScript>().prev = Tiles[checkPos];

            unvisited.Remove(checkPos + 1);
            if (Tiles[checkPos + 1].GetComponent<TileScript>().target == true)
            {
                foundPos = checkPos + 1;
                foundTarget = true;
                return;
            }
        }

        //Down
        if (checkedTile.down == true && !(visited.Contains(checkPos - length)) && !(closed.Contains(checkPos - length)))
        {
            Debug.Log(checkPos - length);
            visited.Add(checkPos - length);
            Tiles[checkPos - length].GetComponent<TileScript>().Object.material = materialvisited;
            Tiles[checkPos - length].GetComponent<TileScript>().prev = Tiles[checkPos];

            unvisited.Remove(checkPos - length);
            if (Tiles[checkPos - length].GetComponent<TileScript>().target == true)
            {
                foundPos = checkPos - length;
                foundTarget = true;
                return;
            }
        }

        //Left
        if (checkedTile.left == true && !(visited.Contains(checkPos - 1)) && !(closed.Contains(checkPos - 1)))
        {
            Debug.Log(checkPos - 1);
            visited.Add(checkPos - 1);
            Tiles[checkPos - 1].GetComponent<TileScript>().Object.material = materialvisited;
            Tiles[checkPos - 1].GetComponent<TileScript>().prev = Tiles[checkPos];
            unvisited.Remove(checkPos - 1);
            if (Tiles[checkPos - 1].GetComponent<TileScript>().target == true)
            {
                foundPos = checkPos - 1;
                foundTarget = true;
                return;
            }
        }
        ////Up
        //if (Tiles[checkPos].GetComponent<TileScript>().up == true && Tiles[checkPos + length].GetComponent<TileScript>().visited == false)
        //{
        //    visited.Add(checkPos + length);
        //    unvisited.Remove(checkPos + length);
        //    Tiles[checkPos].GetComponent<TileScript>().visited = true;
    }


    void Djikstra()
    {
        
    }



}
