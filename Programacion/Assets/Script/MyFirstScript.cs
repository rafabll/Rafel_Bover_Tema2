using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    
    [SerializeField] private bool gameOver = false;
    */

    public string playerName = "Rafa";
    public string enemyName = "Rafa ";

    [SerializeField] private int x = 5;
    [SerializeField] private int y = 3;
    [SerializeField] private int z = 3;

    //Esta bolean es para hacer que llueva
    [SerializeField] private bool isRaining;

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
     */  
     
     if (playerName == enemyName)
     {

      Debug.Log(message: "Player y enemigo se llaman igual");

     }

     if(playerName != enemyName)
     {

      Debug.Log(message: "Player y enemigo tienen distinto nombre");

     }

        
    }

    // Update is called once per frame
    void Update()
    {
   
     //Mensaje que saldra cuando se active la lluvia
     /*
     if (isRaining)
     {
     Debug.Log(message: "Llévate un paraguas");
     }
     */

    }
}
