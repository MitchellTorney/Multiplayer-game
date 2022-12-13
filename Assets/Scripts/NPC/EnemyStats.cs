using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public EntityStats EnemyHealth;
    public float MaxHealth;


    public void Awake(){ 
        Debug.Log("Enemy starting health is: " + MaxHealth);
    }
    void Update()
    {
        bugcheck();
    }

    void bugcheck()
    { 
        if (Input.GetKeyDown(KeyCode.B))
        {
            //Debug.Log("Now your health is: " + PlayerHealth.value);
        }
    }

    private void OnTriggerEnter(Collider other)
    {   
    MaxHealth = MaxHealth - 10;  
    Debug.Log(MaxHealth);
    }
}
