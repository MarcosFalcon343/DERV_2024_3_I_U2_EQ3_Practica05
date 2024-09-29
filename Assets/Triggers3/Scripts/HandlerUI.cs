using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HandlerUI : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI zonaAparicion;
    [SerializeField] public TextMeshProUGUI vida;
    [SerializeField] public TextMeshProUGUI zona;


    public void cambiarVida(int vida)
    {
        this.vida.text = vida.ToString();
    }

    public void cambiarZona(string zona)
    {
        this.zona.text = zona;
    }

    public void cambiarZonaAparicion(string zona)
    {
        zonaAparicion.text = zona;
    }
}
