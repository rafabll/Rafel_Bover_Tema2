using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parimpar : MonoBehaviour
{
    public int year = 2021;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            year = int.Parse(GetComponent<InputField>().text);

            ParImpar(year);
        }
    }
    public void ParImpar(int year)
    {
        if (year % 2 == 0)
        {
            Debug.Log(message: $"El año {year} es par.");
        }
        else
        {
            Debug.Log(message: $"El año {year} es impar.");
        }
    }
}
