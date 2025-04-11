using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tresGustos : MonoBehaviour
{
    public float cantidad;
    public string sabor;

    int cantidadMaxima = 3000;
    int cantidadMinima = 250;

    string choCode = "CHO";
    string ddlCode = "DDL";
    string fruCode = "FRU";

    float precioGramo = 1.25f;
    float precioTotal;
    float descuento = 0.9f;
    // Start is called before the first frame update
    void Start()
    {
        if(cantidad < cantidadMinima || cantidad > cantidadMaxima)
        {
            Debug.Log("Cantidad no valida. Ingresar una cantidad mayor a 250 gramos y menor a 3000 gramos (3 kilos)");
            return;
        }
        if(sabor != choCode && sabor != ddlCode && sabor != fruCode)
        {
            Debug.Log("Codigo de Sabor no valido, Ingrese un codigo valido");
            return;
        }
        if(sabor == choCode && cantidad < cantidadMaxima && cantidad > cantidadMinima)
        {
            precioTotal = cantidad * precioGramo;
            Debug.Log("El Precio por " + cantidad + " gramos es de $" + precioTotal);
        } else if (sabor == ddlCode && cantidad < cantidadMaxima && cantidad > cantidadMinima)
        {
            precioTotal = cantidad * precioGramo;
            Debug.Log("El Precio por " + cantidad + " gramos es de $" + precioTotal);
        }else if (sabor == fruCode && cantidad < cantidadMaxima && cantidad > cantidadMinima)
        {
            precioTotal = (cantidad * precioGramo) * descuento;
            Debug.Log("El Precio por " + cantidad + " gramos es de $" + precioTotal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
