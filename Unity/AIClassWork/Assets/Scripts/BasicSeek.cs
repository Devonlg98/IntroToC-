using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSeek : MonoBehaviour
{
    // The object that this agent is seeking out


    public AIManager aiMan;
    public Transform tmpTarget;
    public Transform obstacle;
    public float maxVelocity = 1f;
    public float speed = 50f;
    public float mass = 1f;
    public float maxSpeed = 5f;
    Vector3 velocity = Vector3.zero;
    Vector3 force;
    Vector3 v;
    Vector3 CurrentVelocity;
    
    void start()
    {
    }
    void Update()
    {

        Debug.DrawRay(transform.position, tmpTarget.position - transform.position, Color.red, 0f);
        Debug.DrawRay(transform.position, obstacle.position - transform.position, Color.red, 0f);

        float distanceToTarget = Vector3.Distance(tmpTarget.position, transform.position);
        float distanceToObstacle = Vector3.Distance(obstacle.position, transform.position);
        Debug.Log("Distance to Target is : " + (int)distanceToTarget);



        //Vector3 newDirection = Vector3.RotateTowards(v, tmpTarget.forward, steerSpeed * Time.deltaTime, 0.0f);
        //rb.AddForce(transform.forward * speed);
        //v = ((tmpTarget.position - transform.position) * maxVelocity).normalized;
        //force = v - CurrentVelocity;
        //CurrentVelocity += force * Time.deltaTime;
        //transform.position += CurrentVelocity * Time.deltaTime;






        if (distanceToTarget < 15)
        {
            Debug.DrawRay(transform.position, tmpTarget.position - transform.position, Color.green, 0f);
            Seek();

        }
        //if (distanceToObstacle < 10)
        //{
        //    Debug.DrawRay(transform.position, obstacle.position - transform.position, Color.green, 0f);

        //    Flee();
        //}

    }


    void Seek()
    {

        v = ((tmpTarget.position - transform.position) * maxVelocity).normalized;
        force = v - CurrentVelocity;
        CurrentVelocity += force * Time.deltaTime;
        transform.position += CurrentVelocity * Time.deltaTime;
        aiMan.AiSteer(v);

    }

    void Flee()
    {

        v = ((transform.position - tmpTarget.position) * maxVelocity).normalized;
        force = v - CurrentVelocity;
        CurrentVelocity += force * Time.deltaTime;
        transform.position += CurrentVelocity * Time.deltaTime;
        //Steering();

    }

    void Steering()
    {


        //Vector3 steering = Vector3.ClampMagnitude(v, maxVelocity);
        //steering /= mass;
        //velocity = Vector3.ClampMagnitude(velocity + steering, maxSpeed);
        //transform.position += velocity * Time.deltaTime;
        //if (velocity != Vector3.zero)
        //{
        //    transform.forward = velocity.normalized;

        //}
        //Debug.DrawRay(transform.position, tmpTarget.forward, Color.red, 0f);
    }
}
