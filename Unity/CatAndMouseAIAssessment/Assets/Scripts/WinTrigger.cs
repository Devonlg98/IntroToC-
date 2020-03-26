using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameManager gameMan;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mouse")
        {
            gameMan.gotCheese();
            
        }
    }
}
