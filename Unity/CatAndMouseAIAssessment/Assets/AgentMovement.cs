using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class AgentMovement : MonoBehaviour
{
    public Agent agent;
    public TileMapping tileMap;

    Vector3 v;

    float distanceToTarget;
    int idx = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // NO PATH, BAIL
        if (tileMap.pathVec3.Length == 0) { return; }

        v = (tileMap.pathVec3[idx] - transform.position).normalized;
        agent.AiSteer(v);

        distanceToTarget = Vector3.Distance(tileMap.pathVec3[idx], transform.position);
        if (distanceToTarget < 1.1f)
        {

            if (idx + 1 < tileMap.pathVec3.Length)
            {

                idx += 1;
            }
        }
    }
}
