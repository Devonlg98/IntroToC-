using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWander : MonoBehaviour
{
    public AIManager aiMan;
    public float maxVelocity = 1f;
    public float smooth = 5f;
    float rotateY = 5f;
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
        v = ((transform.position) * maxVelocity);
        force = v - CurrentVelocity;
        CurrentVelocity += force * Time.deltaTime;
        transform.position += CurrentVelocity * Time.deltaTime;
        aiMan.AiSteer(v);

    }
}
