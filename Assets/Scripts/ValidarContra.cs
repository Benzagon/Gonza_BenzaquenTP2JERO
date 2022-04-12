using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string contraseniaCorrecta, contraseniaUsr;
    public Text ingresoUsr;
    public Text txtMsj;
    public GameObject cartelMsj;

    void Start()
    {
        contraseniaCorrecta = "12345";
        cartelMsj.SetActive(false);
    }

    void Update()
    {

    }

    public void validarContra()
    {
        contraseniaUsr = ingresoUsr.text;

        if(contraseniaUsr == contraseniaCorrecta)
        {
            txtMsj.text = "¡Bienvenido!";
            cartelMsj.SetActive(true);
            Debug.Log("Bienvenido");
        }
        else
        {
            txtMsj.text = "Contraseña Incorrecta";
            cartelMsj.SetActive(true);
            Debug.Log("Contraseña incorrecta");
        }
    }
}
