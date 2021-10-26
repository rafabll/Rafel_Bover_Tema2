using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneLimits : MonoBehaviour
{
    // Velocidad de movimiento.
    private float speed = 50f;
    // Velocidad de giro.
    private float turnSpeed = 50f;
    // Controladores de movimiento.
    public float horizontalInput;
    public float verticalInput;

    // Limites del mapa.
    private float limPosX = 50f;
    private float limNegX = -50f;
    private float limY = 0.5f;
    private float limPosZ = 25f;
    private float limNegZ = -25f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x: 0f, y: 0.5f, z: 0f);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Movimiento hacia delante.
        transform.Translate(translation: Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Rotacion horizontal.
        transform.Translate(translation: Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        //Límites de pantalla.
        if (transform.position.x >= limPosX)
        {
            transform.position = new Vector3(limPosX, transform.position.y, transform.position.z);
        }

        if (transform.position.x <= limNegX)
        {
            transform.position = new Vector3(limNegX, transform.position.y, transform.position.z);
        }

        if (transform.position.y >= limY)
        {
            transform.position = new Vector3(transform.position.x, limY, transform.position.z);
        }

        if (transform.position.y <= -limY)
        {
            transform.position = new Vector3(transform.position.x, -limY, transform.position.z);
        }

        if (transform.position.z >= limPosZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limPosZ);
        }

        if (transform.position.z <= limNegZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limNegZ);
        }
    }
}
