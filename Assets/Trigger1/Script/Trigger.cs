using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]GameObject plancha_resultado;
    public Texture[] imagenes;
    Renderer rend;  
    public Texture ImagenAnimal;
    private Texture texturaOriginal;


    public void Start(){
        rend = plancha_resultado.GetComponent<Renderer>();
        texturaOriginal = rend.material.mainTexture;
    }
    
    private void OnTriggerEnter(Collider other){
        rend.material.mainTexture = ImagenAnimal;
    }

     private void OnTriggerExit(Collider other){
        rend.material.mainTexture = texturaOriginal;
     }
}
