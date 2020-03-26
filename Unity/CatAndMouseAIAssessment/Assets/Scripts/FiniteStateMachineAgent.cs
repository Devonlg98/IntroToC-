using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteStateMachineAgent : MonoBehaviour
{
    public Agent agent;
    public AgentMovement agentMovement;
    public TileScript tileScript;
    public TileMapping tileMap;



    public enum States
    {
        Search,
        Seek,
        Patrol,
        Pounce
    }

    public Vector3[] patrolLocations;
    public int currentPatrolIndex;
    public bool searchFinished = false;

    public Transform seekTarget;

    private States currentState;

    void Update()
    {
        switch (currentState)
        {
            case States.Search:
                Search();
                break;
            case States.Seek:
                Seek();
                break;
            case States.Patrol:
                Patrol();
                break;
            case States.Pounce:
                Pounce();
                break;

            default:
                Debug.LogError("Invalid state!");
                break;
        }
        //reset state to search
        if (searchFinished == false)
        {
            currentState = States.Search;
        }
        //if search works, seek target, if false patrol

        if(tileMap.foundTarget == true)
        {
            currentState = States.Seek;
            if (agentMovement.distanceToMouse < 1)
            {
                currentState = States.Pounce;
            }
        }
        else if (searchFinished == true)
        {
            currentState = States.Patrol;
        }




        // TODO: add ways to switch from one state to the next
    }

    void Search()
    {
        tileMap.foundTarget = false;
        Debug.Log("Searching");
        tileMap.TileMappingVoid();
        searchFinished = true;
        tileMap.unvisited = new List<int>(tileMap.unvistedSave);
        tileMap.closed.Clear();
        tileMap.visited.Clear();
        tileMap.visited.Add(tileMap.AIpos);

    }
    void Patrol()
    {
        Debug.Log("Patrolling");

        //tileMap.TileMappingVoid();
        //patrol
        searchFinished = false;


    }
    void Seek()
    {
        Debug.Log("Seeking");

        agentMovement.AgentMovementVoid();
    }
    void Pounce()
    {
        Debug.Log("Pouncing");

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
