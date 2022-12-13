using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CharacterInterface : MonoBehaviour
{
//Information relating to the in game character interface
    public Slider slider;
    public CharacterStats characterStats;  
       

    public void SetMaxHealth(float maxHealth)
    {
            slider.maxValue = maxHealth;
            slider.value = maxHealth;
    }

    public void SetCurrentHealth(float currentHealth)
    {
            slider.value = currentHealth;
    }
}
