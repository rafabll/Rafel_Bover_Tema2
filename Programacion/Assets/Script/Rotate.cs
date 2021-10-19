using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateGameObject(new Vector3 (0, 10, 0), KeyCode.RightArrow);
        RotateGameObject(new Vector3 (0, -10, 0), KeyCode.LeftArrow);
        RotateGameObject(new Vector3 (0, 0, 10), KeyCode.UpArrow);
        RotateGameObject(new Vector3 (0, 0, -10), KeyCode.DownArrow);
    }
    public void RotateGameObject(Vector3 Rotation, KeyCode kCode)
    {
        if (Input.GetKeyDown(kCode))
        {
            transform.rotation *= Quaternion.Euler (Rotation);
        }
    }

}
