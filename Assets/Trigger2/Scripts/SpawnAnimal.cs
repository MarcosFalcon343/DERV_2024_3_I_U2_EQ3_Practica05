using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    public GameObject animalPrefab;  
    public Transform spawnPoint;     

    private GameObject animalInstanciado; 

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && animalInstanciado == null)
        {
            
            animalInstanciado = Instantiate(animalPrefab, spawnPoint.position, spawnPoint.rotation); 
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && animalInstanciado != null)
        {
            
            Destroy(animalInstanciado); 
            animalInstanciado = null;   
        }
    }
}
