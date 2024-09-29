using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Personaje : MonoBehaviour
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
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        } else if(Input.GetKey(KeyCode.A)){
            transform.position += velocidad_movimiento * -1 * Time.deltaTime * transform.forward;
        }

        if(Input.GetKey(KeyCode.W)){
            transform.position += velocidad_movimiento * -1 * Time.deltaTime * transform.right;
        } else if(Input.GetKey(KeyCode.S)){
            transform.position += velocidad_movimiento * Time.deltaTime * transform.right;
        }

        if(Input.GetKey(KeyCode.Q)){
            transform.Rotate(0, velocidad_rotacion * Time.deltaTime,0);
        } else if(Input.GetKey(KeyCode.E)){
            transform.Rotate(0, -1 * velocidad_rotacion * Time.deltaTime,0);
        }

    }
}
