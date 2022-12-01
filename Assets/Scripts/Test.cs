using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{ 
    int [] data;
    void Start()
    {
        PlayerClass wizardo = new PlayerClass ();
        /*
        wizardo.PlayerInfo ();
        wizardo.name = "Arch Wizard";
        wizardo.health = 400;
        wizardo.PlayerInfo ();

        PlayerClass rogue = new PlayerClass (); 
        rogue.name = "Rogue";
        rogue.health = 5;
        rogue.PlayerInfo (); 
        
        data = ProcessArrays (data);
        spitoutarray();*/
    } 

    public int[] ProcessArrays(int[] data)
    { 
        data = new int[20];
        for (int i = 0; i < data.Length; i++)
        {
            data [i] = Random.Range(0, 100);
            Debug.Log("The element at index" + i + " has a value of " + data[i]);
        }
        Debug.Log("winner is " + data[0]);
        return data;
    }

    public void spitoutarray()
    {
            Debug.Log ("Player array is " + data[2]);

    }
    void Update()
    {
        
    }
}
