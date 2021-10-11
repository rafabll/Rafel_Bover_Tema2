using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    
    [SerializeField] private bool gameOver = false;
   

    public string playerName = "Rafa";
    public string enemyName = "Rafa ";

    public int playerAge = 15;

    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;
    [SerializeField] private int z = 3;
    [SerializeField] private int playerHP = 10;
    */
    //Esta bolean es para hacer que llueva
    [SerializeField] private bool isRaining;
    // Para activar el frio
    [SerializeField] private bool isCold;

    // Start is called before the first frame update
    void Start()
    {

        /*
        Debug.Log(playerAge);
        Debug.Log(message: $"Hola {playerName}!");
        Debug.Log(message: $"Suma: {x} + {y} ={x + y}");
        Debug.Log(message: "Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log(message: string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(message: string.Format("Division: {0} / {1} = {2}", x, y, x / y));

        if (playerName == enemyName)
        {

         Debug.Log(message: "Player y enemigo se llaman igual");

        }

        if(playerName != enemyName)
        {

         Debug.Log(message: "Player y enemigo tienen distinto nombre");

        }

        if (playerHP > 0)
         {
               Debug.Log(message: "Sigues vivo");
         }
        else
         {
               Debug.Log(message: "Estás muerto.");
         }
        
        if (playerAge < 13)
        {
            Debug.Log(message: "Eres un niño.");
        }
        else if (playerAge < 18)
        {
            Debug.Log(message: "Eres un adolescente.");
        }
        else
        {
            Debug.Log(message: "Eres un adulto.");
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
       /* 
     if (isRaining == true)
     {
   
            if (isCold)
            {
                Debug.Log(message: "Llevate un paraguas y una sudadera.");
            }
            else
            {
                Debug.Log(message: "Lleva un paraguas.");
            }
     }
     else
     {
         Debug.Log(message: "No llueve.");
     }
       */    

    }
}
