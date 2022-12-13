using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayerTest : MonoBehaviour
{
    public float damage = 0.02f;
    
    void Start ()
    {
        Debug.Log("TEST");
    }

    private void OnTriggerEnter(Collider other)
    {
         CharacterStats playerStats = other.GetComponent<CharacterStats>();
           Debug.Log("HIT");

            playerStats.TakeDamage(damage); 
        
    }

  
 
}
