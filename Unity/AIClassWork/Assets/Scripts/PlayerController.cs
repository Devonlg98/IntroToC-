using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private CharacterController P_control;
    // Start is called before the first frame update
    void Start()
    {
        P_control = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        P_control.Move(move * Time.deltaTime * speed);
        if (move != Vector3.zero)
            transform.forward = move;
    }
}
