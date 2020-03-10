using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class TileMapping : MonoBehaviour
{
    public Transform Target;
    public Transform AI;
    public int AIpos;
    public int targetPos;
    private int foundPos;
    public TileScript tileScript;
    public GameObject tilePrefab;
    bool whileBreaker = true;
    bool foundTarget = false;
    public int length;
    private int tileCount = 0;
    public List<int> unvisited = new List<int>();
    public List<int> visited = new List<int>();
    public List<int> closed = new List<int>();
    public List<int> targetPath = new List<int>();

    public Material materialVisited;
    public Material materialClosed;
    public Material materialPath;



    public GameObject[] Tiles;
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
        Tiles[AIpos].GetComponent<TileScript>().weight = 0;
        Tiles[7].GetComponent<TileScript>().weight = 30;
        Tiles[37].GetComponent<TileScript>().weight = 30;
        Tiles[67].GetComponent<TileScript>().weight = 30;
        Tiles[97].GetComponent<TileScript>().weight = 30;
        Tiles[127].GetComponent<TileScript>().weight = 30;
        Tiles[157].GetComponent<TileScript>().weight = 30;
        Tiles[187].GetComponent<TileScript>().weight = 30;
        Tiles[217].GetComponent<TileScript>().weight = 30;
        Tiles[247].GetComponent<TileScript>().weight = 30;

    }

    // Update is called once per frame
    void Update()
    {

        while (unvisited.Count > 1 && foundTarget == false)
        {
            surroundingCheck(visited[0]);           
        }

        if(foundTarget == true && whileBreaker == true)
        {
            GameObject temp = Tiles[0];
            targetPath.Add(Tiles[foundPos].GetComponent<TileScript>().ID);
            while (Tiles[foundPos].GetComponent<TileScript>().ID != AIpos)
            {
                Tiles[foundPos] = Tiles[foundPos].GetComponent<TileScript>().prev;
                Tiles[foundPos].GetComponent<TileScript>().Object.material = materialPath;
                targetPath.Add(Tiles[foundPos].GetComponent<TileScript>().ID);
                foundPos = Tiles[foundPos].GetComponent<TileScript>().ID;
            }
            whileBreaker = false;
        }
    }



    void instMap()
    {

        Tiles = new GameObject[length *length];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            { 
                Tiles[tileCount] = Instantiate(tilePrefab, new Vector3(j * 1.1f, 0f, i * 1.1f), Quaternion.identity);
                Tiles[tileCount].name = "Tile " + tileCount;
                Tiles[tileCount].GetComponent<TileScript>().ID = tileCount;
                //if (walls.Contains(tileCount))
                //{
                //    Tiles[tileCount].GetComponent<TileScript>().weight = 30;
                //}
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
        Tiles[visited[0]].GetComponent<TileScript>().Object.material = materialClosed;
        visited.RemoveAt(0);
        closed.Add(checkPos);
        TileScript checkedTile = Tiles[checkPos].GetComponent<TileScript>();
        //visited = visited.OrderBy(Tiles[checkPos] >= Tiles[checkPos].GetComponent<TileScript>().weight).ToList();


        //Up
        if (checkedTile.up == true && !(visited.Contains(checkPos + length)) && !(closed.Contains(checkPos + length)))
        {
            if(checkedTile.up.GetComponent<TileScript>().weight > 20)
            {
                closed.Add(checkPos+length);
                unvisited.Remove(checkPos + length);

            }
            else
            {
                Debug.Log(checkPos + length);
                visited.Add(checkPos + length);
                Tiles[checkPos + length].GetComponent<TileScript>().Object.material = materialVisited;
                Tiles[checkPos + length].GetComponent<TileScript>().prev = Tiles[checkPos];
                unvisited.Remove(checkPos + length);
                if (Tiles[checkPos + length].GetComponent<TileScript>().target == true)
                {
                    foundPos = checkPos + length;
                    foundTarget = true;
                    return;
                }
            }


        }

        //Right
        if (checkedTile.right == true && !(visited.Contains(checkPos + 1)) && !(closed.Contains(checkPos +1 )))
        {
            if (checkedTile.up.GetComponent<TileScript>().weight > 20)
            {
                closed.Add(checkPos + 1);
                unvisited.Remove(checkPos + 1);

            }
            else
            {
                Debug.Log(checkPos + 1);
                visited.Add(checkPos + 1);
                Tiles[checkPos + 1].GetComponent<TileScript>().Object.material = materialVisited;
                Tiles[checkPos + 1].GetComponent<TileScript>().prev = Tiles[checkPos];
                unvisited.Remove(checkPos + 1);
                if (Tiles[checkPos + 1].GetComponent<TileScript>().target == true)
                {
                    foundPos = checkPos + 1;
                    foundTarget = true;
                    return;
                }
            }

        }

        //Down
        if (checkedTile.down == true && !(visited.Contains(checkPos - length)) && !(closed.Contains(checkPos - length)))
        {

            if (checkedTile.up.GetComponent<TileScript>().weight > 20)
            {
                closed.Add(checkPos - length);
                unvisited.Remove(checkPos - length);

            }
            else
            {
                Debug.Log(checkPos - length);
                visited.Add(checkPos - length);
                Tiles[checkPos - length].GetComponent<TileScript>().Object.material = materialVisited;
                Tiles[checkPos - length].GetComponent<TileScript>().prev = Tiles[checkPos];
                unvisited.Remove(checkPos - length);
                if (Tiles[checkPos - length].GetComponent<TileScript>().target == true)
                {
                    foundPos = checkPos - length;
                    foundTarget = true;
                    return;
                }
            }

        }

        //Left
        if (checkedTile.left == true && !(visited.Contains(checkPos - 1)) && !(closed.Contains(checkPos - 1)))
        {
            if (checkedTile.up.GetComponent<TileScript>().weight > 20)
            {
                closed.Add(checkPos - 1);
                unvisited.Remove(checkPos - 1);

            }
            else
            {
                Debug.Log(checkPos - 1);
                visited.Add(checkPos - 1);
                Tiles[checkPos - 1].GetComponent<TileScript>().Object.material = materialVisited;
                Tiles[checkPos - 1].GetComponent<TileScript>().prev = Tiles[checkPos];
                unvisited.Remove(checkPos - 1);
                if (Tiles[checkPos - 1].GetComponent<TileScript>().target == true)
                {
                    foundPos = checkPos - 1;
                    foundTarget = true;
                    return;
                }
            }

        }
    }



}
