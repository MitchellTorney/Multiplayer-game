using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour
{
    //Handles everything relating to a players statistics
    //Also conveys information to UI 
    public Entity entity;
    float maxHealth;
    float currentHealth;
    public CharacterInterface characterInterface;

    void Awake()
    {   
         
        maxHealth = entity.stats.MaxValue;   
        currentHealth = maxHealth; 
        characterInterface.SetMaxHealth(maxHealth);
        Debug.Log("Current health "+ currentHealth + " Max health " + maxHealth); 
    }
 
 
    
    public void TakeDamage(float damage)
    {
        currentHealth = Mathf.Max(0, currentHealth - damage);
        characterInterface.SetCurrentHealth(currentHealth);
        Debug.Log("Current health: "+ currentHealth);
    }
      



}
