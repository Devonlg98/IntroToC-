using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class AgentMovement : MonoBehaviour
{
    public Agent agent;
    public TileMapping tileMap;

    public Transform mouse;

    Vector3 v;

    public float distanceToMouse;
    float distanceToTarget;
    public int idx = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanceToMouse = Vector3.Distance(mouse.position, transform.position);
    }




    public void AgentMovementVoid()
    {
        if (tileMap.startMovement == true)
        {

            v = (tileMap.pathVec3[idx] - transform.position).normalized;
            agent.AiSteer(v);
            //Distance to Tile
            distanceToTarget = Vector3.Distance(tileMap.pathVec3[idx], transform.position);
            if (distanceToTarget < .1f)
            {
                idx--;
                if (idx < 0)
                {
                    tileMap.startMovement = false;
                    agent.maxSpeed = 0;

                }
            }
        }
    }
}
