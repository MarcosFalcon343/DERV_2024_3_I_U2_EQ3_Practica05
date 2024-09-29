using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerGame : MonoBehaviour
{
    private int vida = 1000;
    private string zona = "Exterior";
    private string zonaAparicion = "Origen";
    private Transform zonaAparicionTransform;

    [SerializeField] public HandlerUI handlerUI;
    [SerializeField] public Pedro_Movimiento movimientoPersonaje;
    void Start()
    {
        zonaAparicionTransform = transform;
        handlerUI.cambiarVida(vida);
        handlerUI.cambiarZona(zona);
        handlerUI.cambiarZonaAparicion(zonaAparicion);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            vida = 1000;
            transform.position = zonaAparicionTransform.position;
            handlerUI.cambiarVida(vida);
            movimientoPersonaje.revivirPedro();
        }
    }

    public void restarVida(int vida)
    {
        this.vida -= vida;
        handlerUI.cambiarVida(this.vida);

        if (this.vida <= 0)
        {
            movimientoPersonaje.matarPedro();
        }
    }


}
