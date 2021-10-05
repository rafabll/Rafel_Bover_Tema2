using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Sonido que har�n los veh�culos 
    [SerializeField] private string sound = "�Brum, brum!";
    
    // Nombres de los veh�culos
    [SerializeField] private string name = "Coche";
    
    // N�mero de ruedas que tienen los veh�culos
    [SerializeField] private int numberWheels = 4;

    // Sirena de la ambulancia
    [SerializeField] private bool hasSiren = false;

    // Start is called before the first frame update
    void Start()
    {
       
     
        // Debug.Log(message: $"{name} tiene {numberWheels} ruedas y hace {sound}");
        Debug.Log(message: string.Format("{1} tiene {2} ruedas y hace {0}", sound, name, numberWheels)); 
       
        // Si la sirena se activa aparecer� una notificaci�n
        if(hasSiren == true)
        {
            Debug.Log(message: $"{name} tiene sirena");
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
