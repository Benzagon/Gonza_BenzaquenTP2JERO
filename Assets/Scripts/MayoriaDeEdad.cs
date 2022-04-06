using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadUsusario;

    void Start()
    {
        if(edadUsusario >= 10)
        {
            Debug.Log("Es mayor de edad");
        }
        else
        {
            Debug.Log("No es mayor de edad");
        }
    }

    void Update()
    {
        
    }
}
