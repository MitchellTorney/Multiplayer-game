using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName="Health Value")]
public class HealthValue : ScriptableObject
{
     public float value;
     public float maxvalue;
 

     void awake ()
     {
          value = maxvalue;
          
     }
}
