using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    /*
    // Sonido que har�n los veh�culos 
    [SerializeField] private string sound = "�Brum, brum!";
    
    // Nombres de los veh�culos
    [SerializeField] private string name = "Coche";
    
    // N�mero de ruedas que tienen los veh�culos
    [SerializeField] private int numberWheels = 4;

    // Sirena de la ambulancia
    [SerializeField] private bool hasSiren = false;

    // Encendido y apagado del veh�culo
    [SerializeField] private bool isOn = true;

    // Gasolina de los veh�culos
    [SerializeField] private float gasoline = 8.25f;
    */
    // Start is called before the first frame update
    void Start()
    {
       
     /*
        // Debug.Log(message: $"{name} tiene {numberWheels} ruedas y hace {sound}");
        Debug.Log(message: string.Format("{1} tiene {2} ruedas y hace {0}", sound, name, numberWheels)); 
       
        // Si la sirena se activa aparecer� una notificaci�n
        if(hasSiren == true)
        {
            Debug.Log(message: $"{name} tiene sirena");
        }
        else
        {
            Debug.Log(message: $"{name} no tiene sirena");
        }
     
     if (isOn == true)
        {
            Debug.Log(message: $"{sound}");
        }
     else if (hasSiren == true)
        {
            Debug.Log(message: $"{name} har� {sound} cuando se ponga en marcha");
        }
     else 
        {
            Debug.Log(message: $"{name} no est� en marcha");
        }
        
     if (isOn == true)
        {
            if (gasoline < 10)
            {
                Debug.Log(message: $"�A {name} le queda poca gasolina!");
            }
            if (hasSiren == true)
            {
                Debug.Log(message: $"{sound}");
            }
            else
            {
                Debug.Log(message: $"{name} no tiene sirena.");
            }
        }
     else
        {
            Debug.Log(message: $"{name} no est� en marcha.");
        }
     */
    }

    // Update is called once per frame
    void Update()
    {
        /*
       if (isOn == true)
        {
           if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position += Vector3.right;
            }

           if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position -= Vector3.right;
            }

           if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position += Vector3.up;
            }

           if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position -= Vector3.up;
            }
        }
       else
        {
            Debug.Log(message: "Enciende el vehicula antes de moverte");
        }
        */
    }
}
