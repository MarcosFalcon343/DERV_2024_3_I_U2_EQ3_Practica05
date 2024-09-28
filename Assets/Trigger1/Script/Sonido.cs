using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sonido : MonoBehaviour
{
    public AudioSource Placa;
    public AudioClip sonido;

    public float volumen = 35;

    private void OnTriggerEnter(Collider other){
        Placa.PlayOneShot(sonido,volumen);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Placa != null)
            {
                Placa.Stop(); // Detiene la música cuando el jugador sale del Trigger
            }
        }
    }


}
