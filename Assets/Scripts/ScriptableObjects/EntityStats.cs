using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName="Entity Stats")]
public class EntityStats : ScriptableObject
{ 
     public float MaxValue;   
     public float Faction; 
     public float CarryMax;  
     public float MaxSanity;




     void Awake()
     {     
          Debug.Log("Testing global value awake");
                     
     }
     
}
 