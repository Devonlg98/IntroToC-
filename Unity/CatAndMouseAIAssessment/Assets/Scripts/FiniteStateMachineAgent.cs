using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteStateMachineAgent : MonoBehaviour
{
    public enum States
    {
        Patrol,
        Seek,
        Flee
    }



    public Vector3[] patrolLocations;
    public int currentPatrolIndex;

    public Transform fleeTarget;
    public Transform seekTarget;

    private States currentState;

    void Update()
    {
        switch (currentState)
        {
            case States.Patrol:
                Patrol();
                break;
            case States.Seek:
                Seek();
                break;
            case States.Flee:
                Flee();
                break;
            default:
                Debug.LogError("Invalid state!");
                break;
        }

        // TODO: add ways to switch from one state to the next
    }

    void Patrol() { /* patrol things */ }
    void Seek() { /* seek things */ }
    void Flee() { /* flee things */ }
}
