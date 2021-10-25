using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessNumber : MonoBehaviour
{
    private int randNum;
    public int playerNum;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(0, 31); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            playerNum = int.Parse(GetComponent<InputField>().text);
           
            if (playerNum == randNum)
            {
                Debug.Log(message: $"¡HAS ACERTADO!");
                Debug.Log(message: $"Intentos: {counter}");
                Destroy(gameObject);
            }

            else if (playerNum < randNum)
            {
                Debug.Log(message: "El número es menor que el introducido.");
                
            }

            else
            {
                Debug.Log(message: "El número es mayor que el introducido.");
            }

            counter++;

        }
    }
}
