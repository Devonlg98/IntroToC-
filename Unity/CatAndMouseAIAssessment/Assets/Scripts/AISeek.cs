using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISeek : MonoBehaviour
{
    public AIManager aiMan;
    private AIManager aiEnem;
    public Transform tmpTarget;
    private GameObject tmpTargetGO;
    public Vector3 pathNextNode;
    private bool dumbBool = true;

    public TileMapping tileMap;
    private int nodeITR;
    public float maxVelocity = 1f;
    public float arriveTurnSpeed = .1f;
    Vector3 force;
    Vector3 v;
    Vector3 CurrentVelocity;
    // Start is called before the first frame update
    void Start()
    {

        
        aiEnem = tmpTarget.GetComponent<AIManager>();
    }

    

    // Update is called once per frame
    void Update()
    {
        if(dumbBool == true)
        {
            //OF COURSE ITS NOT GONNA SHOW A PROPER COUNT, THE COUNT IS ZERO, BECAUSE LIST IS EMPTY AT THE START, DELETE THIS BOOL AND ADD A VERSION OF IT IN TILE MAPPING AND CALL IT HERE YOU, IDIOT
            nodeITR = tileMap.pathVec2.Count;
            dumbBool = false;
        }

        pathNextNode = new Vector3(tileMap.pathVec2[nodeITR].x, 0f, tileMap.pathVec2[nodeITR].y);

        float distanceToTarget = Vector3.Distance(pathNextNode, transform.position);
        if (distanceToTarget < 50)
        {
            nodeITR--;
            if(nodeITR < 0)
            {
                nodeITR = 0;
            }
            if (distanceToTarget < .1)
            {
                Debug.DrawRay(transform.position, tmpTarget.position - transform.position, Color.green, 0f);
                ArriveMovement();


            }
            else
            {
                Debug.DrawRay(transform.position, tmpTarget.position - transform.position, Color.yellow, 0f);
                Movement();

            }

        }
        else
        {
            Debug.DrawRay(transform.position, tmpTarget.position - transform.position, Color.gray, 0f);

        }

        Debug.DrawRay(transform.position, v, Color.gray, 0f);
    }

    void Movement()
    {
        //Not needed can fix, look into Djikastro/navmesh
        v = ((pathNextNode + aiEnem.velocity - transform.position) * maxVelocity).normalized;
        force = v - CurrentVelocity;
        CurrentVelocity += force * Time.deltaTime;
        transform.position += CurrentVelocity * Time.deltaTime;
        aiMan.mass = aiMan.startMass;
        aiMan.AiSteer(v);
    }
    void ArriveMovement()
    {
        v = ((tmpTarget.position - transform.position) * maxVelocity).normalized;
        force = v - CurrentVelocity;
        CurrentVelocity += force * Time.deltaTime;
        transform.position += CurrentVelocity * Time.deltaTime;
        aiMan.AiSteer(v);
        aiMan.mass = 1 / arriveTurnSpeed;
    }



}

