using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bisiesto : MonoBehaviour
{
    public int year = 2016;
    // Start is called before the first frame update
    void Start()
    {
     if (year % 4 == 0)
        {
            if(100 % year == 0 && 400 % year == 0)
            {
                Debug.Log(message: $"El año {year} es un año bisiesto.");
            }
        }
     else
        {
            Debug.Log(message: $"El año {year} no es bisiesto");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
