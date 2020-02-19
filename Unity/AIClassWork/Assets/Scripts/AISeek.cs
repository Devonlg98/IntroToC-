using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISeek : MonoBehaviour
{

    public AIManager aiMan;
    private AIManager aiEnem;
    public Transform tmpTarget;
    private GameObject tmpTargetGO;

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
        

        float distanceToTarget = Vector3.Distance(tmpTarget.position, transform.position);
        if (distanceToTarget < 100)
        {
            if (distanceToTarget < 5)
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
        v = ((tmpTarget.position +aiEnem.velocity - transform.position) * maxVelocity).normalized;
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
        aiMan.mass = 1/arriveTurnSpeed;
    }



}
