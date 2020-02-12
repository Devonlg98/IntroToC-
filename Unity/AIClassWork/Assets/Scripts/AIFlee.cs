using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFlee : MonoBehaviour
{
    public AIManager aiMan;
    public Transform enemyTarget;
    public float maxVelocity = 1f;
    public float panicTurnSpeed = 3f;
    Vector3 velocity = Vector3.zero;
    Vector3 force;
    Vector3 v;
    Vector3 CurrentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToTarget = Vector3.Distance(enemyTarget.position, transform.position);

        if (distanceToTarget < 20)
        {
            if (distanceToTarget < 5)
            {
                Debug.DrawRay(transform.position, enemyTarget.position - transform.position, Color.green, 0f);
                SlowMovement();
            }
            else
            {
                Debug.DrawRay(transform.position, enemyTarget.position - transform.position, Color.yellow, 0f);
                Movement();

            }

        }
        else
        {
            Debug.DrawRay(transform.position, enemyTarget.position - transform.position, Color.gray, 0f);

        }
    }
    void Movement()
    {
        v = ((transform.position - enemyTarget.position) * maxVelocity).normalized;
        force = v - CurrentVelocity;
        CurrentVelocity += force * Time.deltaTime;
        transform.position += CurrentVelocity * Time.deltaTime;
        aiMan.mass = aiMan.startMass;
        aiMan.maxSpeed = aiMan.startMaxSpeed;
        aiMan.AiSteer(v);
    }

    void SlowMovement()
    {
        v = ((transform.position - enemyTarget.position) * maxVelocity).normalized;
        force = v - CurrentVelocity;
        CurrentVelocity += force * Time.deltaTime;
        transform.position += CurrentVelocity * Time.deltaTime;
        aiMan.AiSteer(v);
        aiMan.maxSpeed = panicTurnSpeed;
        aiMan.mass = 1/panicTurnSpeed;
    }
}
