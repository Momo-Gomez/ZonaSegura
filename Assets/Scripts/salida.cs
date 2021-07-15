using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salida : MonoBehaviour
{
    public GameObject personaje;
    public GameObject puerta;
    public GameObject coll;
    void FixedUpdate()
    {
        if (personaje.GetComponent<inventario>().buscarI("Celular") != -1)
        {
            puerta.SetActive(false);
        }
        if (personaje.GetComponent<BoxCollider2D>().IsTouching(coll.GetComponent<BoxCollider2D>()))
        {
            puerta.SetActive(true);
            coll.SetActive(false);
            GetComponentInParent<salida>().enabled = false;
        }
    }
}
