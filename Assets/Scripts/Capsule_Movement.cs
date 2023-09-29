using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_Movement : MonoBehaviour
{
    public float velocidad = 30.0f; // Velocidad de movimiento

    void Update()
    {
        // Obtén las entradas del teclado
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calcula el vector de movimiento
        Vector3 movimiento = new Vector3(horizontal, 0.0f, vertical) * velocidad * Time.deltaTime;

        // Aplica el movimiento al objeto
        transform.Translate(movimiento);
    }

}

