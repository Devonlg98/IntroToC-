using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class ClickMove : MonoBehaviour
{

    public float maxVelocity = 1f;
    public float arriveTurnSpeed = .1f;
    int idx = 0;
    float distanceToTarget;
    Vector3 force;
    Vector3 v;
    Vector3 CurrentVelocity;

    
    public Agent agent;
    NavMeshAgent myNavMeshAgent;
    private NavMeshPath path;
    public LayerMask hitLayers;

    // Start is called before the first frame update
    void Start()
    {
        path = new NavMeshPath();
        myNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < path.corners.Length - 1; i++)
        {
            Debug.DrawLine(path.corners[i], path.corners[i + 1], Color.red);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, hitLayers))
            {
                NavMesh.CalculatePath(transform.position, hit.point, NavMesh.AllAreas, path);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            {
                Vector3 mousePos = Input.mousePosition;
                Ray ray = Camera.main.ScreenPointToRay(mousePos);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    hit.transform.gameObject.SetActive(false);
                }
            }
        }

        // NO PATH, BAIL
        if (path.corners.Length == 0) { return; }

        v = (path.corners[idx] - transform.position).normalized;
        agent.AiSteer(v);

        distanceToTarget = Vector3.Distance(path.corners[idx], transform.position);
        if (distanceToTarget < 1.1f)
        {

            if (idx + 1 < path.corners.Length)
            {

                idx += 1;
            }
        }
    }
}
