using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetWorld : MonoBehaviour
{ 
    
      
    public HealthValue PlayerHealth;
    
    void Start()
    {
        PlayerHealth.value = PlayerHealth.maxvalue;
    }

  
}
