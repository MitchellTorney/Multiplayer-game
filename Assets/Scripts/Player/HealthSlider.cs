using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthSlider : MonoBehaviour
{
    public Slider slider;
    public HealthValue PlayerHealth; 

    public void SetMaxHealth(float maxHealth)
    {
            slider.maxValue = maxHealth ;
            slider.value = maxHealth;
    }

    public void SetCurrentHealth(float currentHealth)
    {
            slider.value = currentHealth;
    }
}
