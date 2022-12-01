using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public HealthValue PlayerHealth;
    public float maxHealth;
    public float currentHealth;
      [SerializeField] HealthSlider healthSlider;

    void Start()
    {
        Debug.Log("Current health "+ currentHealth + " Max health " + maxHealth);
        maxHealth = PlayerHealth.maxvalue;
        currentHealth = maxHealth;
        healthSlider.SetMaxHealth(maxHealth);
        Debug.Log("Current health "+ currentHealth + " Max health " + maxHealth);
    }
    void Update()
    {
        bugcheck();
    }

    void bugcheck()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentHealth = currentHealth-10;
            healthSlider.SetCurrentHealth(currentHealth);
            Debug.Log("Your health is " + currentHealth);
        }
    }
}
