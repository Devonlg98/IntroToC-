using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    public GameManager gameMan;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "mouse")
        {
            gameMan.gotCat();

        }
    }
}
