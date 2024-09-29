using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    public GameObject animalPrefab;  // El prefab del animal que será instanciado
    public Transform spawnPoint;     // El punto donde el animal aparecerá

    private GameObject animalInstanciado; // Referencia al animal instanciado

    // Método que se llama cuando algo entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && animalInstanciado == null)
        {
            // Instanciar el animal en la posición y rotación del spawn point
            animalInstanciado = Instantiate(animalPrefab, spawnPoint.position, spawnPoint.rotation); 
        }
    }

    // Método que se llama cuando algo sale del trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && animalInstanciado != null)
        {
            // Destruye el animal instanciado (despawn)
            Destroy(animalInstanciado); 
            animalInstanciado = null;   // Resetea la referencia a null
        }
    }
}
