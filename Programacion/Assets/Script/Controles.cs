using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    private float limX = 12f;
    private float limYPos = 6f;
    private float limYNeg = -4f;
    private float limZPos = 10f;
    private float limZNeg = -9f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Controladores de movimiento del GameObject.
        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.up, KeyCode.E);
        MoveGameObject(Vector3.down, KeyCode.Q);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);

        //Límites de pantalla.
        if (transform.position.x >= limX)
        {
            transform.position = new Vector3(limX, transform.position.y, transform.position.z);
        }

        if (transform.position.x <= -limX)
        {
            transform.position = new Vector3(-limX, transform.position.y, transform.position.z);
        }

        if (transform.position.y >= limYPos)
        {
            transform.position = new Vector3(transform.position.x, limYPos, transform.position.z);
        }

        if (transform.position.y <= limYNeg)
        {
            transform.position = new Vector3(transform.position.x, limYNeg, transform.position.z);
        }

        if (transform.position.z >= limZPos)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limZPos);
        }

        if (transform.position.z <= limZNeg)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limZNeg);
        }
    }
    public void MoveGameObject(Vector3 direction, KeyCode kCode)
    {
        if (Input.GetKeyDown(kCode))
        {
            transform.position += direction;
        }
    }
}
