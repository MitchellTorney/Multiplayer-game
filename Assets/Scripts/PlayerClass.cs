using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    public float health = 100f;
    public string name = "Wizardo";
    Test testingarrays = new Test();
    

    public void PlayerInfo() {
            Debug.Log ("Player Name Is: " + name + " and players health is : " + health);
 
    }


    
}
