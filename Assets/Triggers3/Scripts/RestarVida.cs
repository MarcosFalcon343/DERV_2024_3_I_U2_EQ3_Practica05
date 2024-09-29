using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestarVida : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Restando vida");
        }
    }
}
