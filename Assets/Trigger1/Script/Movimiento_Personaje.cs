using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Personaje : MonoBehaviour
{
    public float velocidad_rotacion = 10;

    public float velocidad_movimiento = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            transform.rotation = Quaternion.Euler(0, 0, 0); // Rotar en el eje Y a 0 grados
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }else if(Input.GetKey(KeyCode.A)){
            transform.rotation = Quaternion.Euler(0, 180, 0); // Rotar en el eje Y a 0 grados
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }else if(Input.GetKey(KeyCode.W)){
            transform.rotation = Quaternion.Euler(0, -90, 0); // Rotar en el eje Y a 0 grados
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }else if(Input.GetKey(KeyCode.S)){
            transform.rotation = Quaternion.Euler(0, 90, 0); // Rotar en el eje Y a 0 grados
            transform.position += velocidad_movimiento *Time.deltaTime * transform.forward;
        }
    }

}

