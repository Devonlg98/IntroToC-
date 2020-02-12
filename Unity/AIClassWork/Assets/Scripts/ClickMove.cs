using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour
{
    public Transform P1Move;
    // Start is called before the first frame update
    public LayerMask hitLayers;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mouse);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, hitLayers))
            {
                P1Move.transform.position = hit.point;
                
            }
        }

    }
}
