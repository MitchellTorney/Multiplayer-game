using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName="Entity Movement")]
public class EntityMovement : ScriptableObject
{  
     
     public string IdentifyMovementType; 
     public float JumpHeight;
     public float JumpAmount;
     public float FlightSpeed;
     public float SwimSpeed;
     public float BaseSpeed;
     public float MaxSpeed;
     
     public float Weight; 
     

     void Awake()
     {     
          Debug.Log("Testing global value awake"); 
     }
     public void DetectMovementType ()
     { 
          switch (IdentifyMovementType)
          {
               case "Flight":
               Debug.Log("Your movement type is:" + JumpHeight );
               break;
          }
     }
}
 