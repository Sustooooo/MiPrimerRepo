using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float velocidad = 10;
    [SerializeField] private Rigidbody rb;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 movimiento = new Vector3(horizontal, 0, vertical) * velocidad * Time.deltaTime;

        rb.AddForce(movimiento);
    }
}
