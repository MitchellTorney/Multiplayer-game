using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Movement Type")]
public class MovementType : ScriptableObject
{
     public float JumpHeight;
     public string IdentifyMovementType; 
     public void GivingMovementPowers()
     {    
          switch (IdentifyMovementType)
          {
               case "Jump":
               Debug.Log("Jump Detected");
               break;
          }
          
                     
     }

}
