using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Establecer_ZonaAparicion : MonoBehaviour
{
    [SerializeField] String nombreZona;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Estableciendo zona de aparición en " + nombreZona);
            //PlayerPrefs.SetString("ZonaAparicion", nombreZona);
        }
    }
}
