using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public float mass = 1f;
    public float maxSpeed = 3.0f;
    public float maxForce = 0.5f;

    Vector3 steeringForce;
    public Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Clamp new Vector 3 "steering" to a maxForce
        Vector3 steering = Vector3.ClampMagnitude(steeringForce, maxForce);
        steeringForce = Vector3.zero;
        steering /= mass;
        velocity = Vector3.ClampMagnitude(velocity + steering, maxSpeed);

        //smooths turns speed
        transform.position += velocity * Time.deltaTime;

        if (velocity != Vector3.zero)
        {
            transform.forward = velocity.normalized;
        }

        Debug.DrawRay(transform.position, steeringForce, Color.green, 0f);
    }

    public void Steer(Vector3 steering)
    {
        steeringForce += steering;
    }

}
