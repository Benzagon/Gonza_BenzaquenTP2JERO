using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadUsusario;
    public Text miTexto;

    void Start()
    {
        if(edadUsusario >= 10)
        {
            Debug.Log("Es mayor de edad");
            miTexto.text = "Es mayor de edad";
        }
        else
        {
            Debug.Log("No es mayor de edad");
            miTexto.text = "No es mayor de edad";
        }
    }

    void Update()
    {
        
    }
}
