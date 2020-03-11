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
    public GameObject wallPrefab;
    bool whileBreaker = true;
    bool foundTarget = false;
    public int length;
    private int tileCount = 0;
    public List<int> unvisited = new List<int>();
    public List<int> visited = new List<int>();
    public List<int> closed = new List<int>();
    public List<int> targetPath = new List<int>();
    private List<int> walls = new List<int> {3, 7, 9, 10, 21, 22, 23, 32, 33, 34, 35, 59, 58, 57, 54, 74, 95, 96, 97, 113, 133, 134, 135, 136, 137, 136, 139, 178, 177, 176, 175, 174, 173, 168, 169, 170, 171, 187, 186, 185, 184, 183, 182, 60, 80, 100, 62, 82, 102, 103, 104, 85, 65, 45, 127, 107, 87, 129, 109, 89, 69, 49, 50, 72, 91, 111, 131, 151, 222, 223, 224, 225, 226, 227, 228, 210, 211, 214, 215, 216, 252, 270, 290, 293, 294 ,296, 297, 298,262,341,321,361,361,362,363,365,366,367,368,368,348,350, 281,242,303,323,264,265,285,325,345,328,288,268,251,213,216,236,209,198,238,218,258,256,250,292,255,254,330,331,332, 334,335,336,337,338,370,372,392,374,375,376,378,141,142,143,144};
    public Material materialVisited;
    public Material materialClosed;
    public Material materialPath;
    public Material materialWall;
    public int pathITR;

    public List<Vector2> pathVec2;
    public GameObject[] Tiles;
    public GameObject[] WallArray;
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
                pathVec2.Add(new Vector2(Tiles[foundPos].GetComponent<TileScript>().x, Tiles[foundPos].GetComponent<TileScript>().y));
                targetPath.Add(Tiles[foundPos].GetComponent<TileScript>().ID);
                foundPos = Tiles[foundPos].GetComponent<TileScript>().ID;
                pathITR++;
                if(pathITR  > pathVec2.Count)
                {
                    pathITR = 0;
                }
            }
            whileBreaker = false;
        }
    }



    void instMap()
    {
        walls.Sort();
        Tiles = new GameObject[length *length];
        WallArray = new GameObject[length*length];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            { 
                Tiles[tileCount] = Instantiate(tilePrefab, new Vector3(j * 1f, 0f, i * 1f), Quaternion.identity);
                Tiles[tileCount].name = "Tile " + tileCount;
                Tiles[tileCount].GetComponent<TileScript>().ID = tileCount;
                Tiles[tileCount].GetComponent<TileScript>().x = j;
                Tiles[tileCount].GetComponent<TileScript>().y = i;
                

                if(walls.Contains(tileCount))
                {
                    Tiles[tileCount].GetComponent<TileScript>().weight = 30;
                    WallArray[tileCount] = Instantiate(wallPrefab, new Vector3(j * 1f, 1f, i * 1f), Quaternion.identity);
                    WallArray[tileCount].name = "Wall " + tileCount;
                }
                tileCount++;
                unvisited.Add(i*length+j);
            }
            
        }
        for (int i = -1; i < length+1; i++)
        {
            for (int j = -1; j < length+1; j++)
            {
                if(i < 0 || i >length-1)
                {
                    Instantiate(wallPrefab, new Vector3(j * 1f, 1f, i * 1f), Quaternion.identity);
                }
                if (j == -1 || j == length)
                {
                    Instantiate(wallPrefab, new Vector3(j * 1f, 1f, i * 1f), Quaternion.identity);
                }
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




        //tiles[5].getcomponent<tilescript>().weight = 30;
        //tiles[5] = instantiate(tileprefab, new vector3(5 * 1.1f, 1f, 0 * 1.1f), quaternion.identity);
        //tiles[5].name = "wall " + tilecount;
        //tiles[50].getcomponent<tilescript>().weight = 30;
        //tiles[25].getcomponent<tilescript>().weight = 30;
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
                Tiles[checkPos + length].GetComponent<TileScript>().Object.material = materialWall;



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
        if (checkedTile.right == true && !(visited.Contains(checkPos + 1)) && !(closed.Contains(checkPos + 1 )))
        {
            if (checkedTile.right.GetComponent<TileScript>().weight > 20)
            {
                closed.Add(checkPos + 1);
                unvisited.Remove(checkPos + 1);
                Tiles[checkPos + 1].GetComponent<TileScript>().Object.material = materialWall;

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

            if (checkedTile.down.GetComponent<TileScript>().weight > 20)
            {
                closed.Add(checkPos - length);
                unvisited.Remove(checkPos - length);
                Tiles[checkPos - length].GetComponent<TileScript>().Object.material = materialWall;

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
            if (checkedTile.left.GetComponent<TileScript>().weight > 20)
            {
                closed.Add(checkPos - 1);
                unvisited.Remove(checkPos - 1);
                Tiles[checkPos - 1].GetComponent<TileScript>().Object.material = materialWall;

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
