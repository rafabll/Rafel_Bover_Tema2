using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x:0, y:0, z:0);
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject(Vector3.right, KeyCode.D);
        MoveGameObject(Vector3.left, KeyCode.A);
        MoveGameObject(Vector3.up, KeyCode.E);
        MoveGameObject(Vector3.down, KeyCode.Q);
        MoveGameObject(Vector3.forward, KeyCode.W);
        MoveGameObject(Vector3.back, KeyCode.S);
        // inputs de escala.
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale -= Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.localScale += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.localScale -= Vector3.up;
        }
        // inputs de posicion.
        /*
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }
        */
    }
    public void MoveGameObject(Vector3 direction, KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode))
        {
            transform.position += direction;
        }
    }
}
