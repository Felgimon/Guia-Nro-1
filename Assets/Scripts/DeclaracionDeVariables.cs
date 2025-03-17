using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    [SerializeField] private int cantCiudades;
    [SerializeField] private float kilometros;
    [SerializeField] private char inicial;
    [SerializeField] private string nombre;
    [SerializeField] private bool presente;

    void Start()
    {
        cantCiudades = 2;
        kilometros = 10.2f;
        inicial = 'F';
        nombre = "Felipe";
        presente = true;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Entero " + cantCiudades);
        Debug.Log("Float " + kilometros);
        Debug.Log("Caracter " + inicial);
        Debug.Log("String " + nombre);
        Debug.Log("Booleano " + presente);
    }
}
