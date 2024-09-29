using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarObjeto : MonoBehaviour
{
    public GameObject objetoSecreto; // El objeto que será activado por esta placa

    // Método que se llama cuando algo entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objetoSecreto.SetActive(true); // Activa el objeto secreto
        }
    }

    // Método que se llama cuando algo sale del trigger (opcional si quieres desactivarlo)
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objetoSecreto.SetActive(false); // Desactiva el objeto secreto si el jugador sale (opcional)
        }
    }
}
