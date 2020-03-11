using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Agent : MonoBehaviour
{
    public float mass = 1f;
    public float maxForce = 1f;
    public float maxSpeed = 5f;
    public Vector3 velocity = Vector3.zero;
    Vector3 steeringVector;

    [HideInInspector]
    public float startMaxSpeed;
    [HideInInspector]
    public float startMass;

    // Start is called before the first frame update
    void Start()
    {
        startMass = mass;
        startMaxSpeed = maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 steering = Vector3.ClampMagnitude(steeringVector, maxForce);
        //Divides steering vector  by mass, to slow the turn speed
        steeringVector = Vector3.zero;
        steering /= mass;
        velocity = Vector3.ClampMagnitude(velocity + steering, maxSpeed);
        //Affects speed of AI
        transform.position += velocity * Time.deltaTime;

        // If velocity isn't zero, set the forward equal to velocity normalized
        if (velocity != Vector3.zero)
        {
            transform.forward = velocity.normalized;

        }
        Debug.DrawRay(transform.position, velocity, Color.red, 0f);

    }

    //Pass through vector from seek and flee
    public void AiSteer(Vector3 v)
    {
        steeringVector += v;
    }
    public void AiSteerWander(Vector3 v)
    {
        steeringVector += v;
    }
}
