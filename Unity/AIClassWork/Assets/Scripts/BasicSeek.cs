using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSeek : MonoBehaviour
{
    // The object that this agent is seeking out
    public Rigidbody rb;
    public Transform tmpTarget;
    public Transform obstacle;
    public float maxVelocity = 1f;
    public float speed = 50f;
    public float steerSpeed = 2f;
    Vector3 force;
    Vector3 v;
    Vector3 CurrentVelocity;
    
    void start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        Debug.DrawRay(transform.position, tmpTarget.position - transform.position, Color.red, 0f);
        Debug.DrawRay(transform.position, obstacle.position - transform.position, Color.red, 0f);
        float distanceToTarget = Vector3.Distance(tmpTarget.position, transform.position);
        float distanceToObstacle = Vector3.Distance(obstacle.position, transform.position);
        Debug.Log("Distance to Target is : " + (int)distanceToTarget);

        if (distanceToTarget < 15 && distanceToTarget >1.5)
        {
            Debug.DrawRay(transform.position, tmpTarget.position - transform.position, Color.green, 0f);
            Seek();

        }
        if(distanceToObstacle < 10)
        {
            Debug.DrawRay(transform.position, obstacle.position - transform.position, Color.green, 0f);

            //Flee();
        }

    }


    void Seek()
    {
        Vector3 newDirection = Vector3.RotateTowards(v, tmpTarget.forward, steerSpeed * Time.deltaTime, 0.0f);
        rb.AddForce(transform.forward * speed);
        v = ((tmpTarget.position - transform.position) * maxVelocity).normalized;
        force = v - CurrentVelocity;
        CurrentVelocity += force * Time.deltaTime;
        transform.position += CurrentVelocity * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(v);
    }

    void Flee()
    {

        rb.AddForce(transform.forward * speed);
        v = ((transform.position - obstacle.position) * maxVelocity).normalized;
        force = v - CurrentVelocity;
        CurrentVelocity += force * Time.deltaTime;
        transform.position += CurrentVelocity * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(v);

    }

    void Steering()
    {

    }
}
