using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName="EntityName")]
public class Entity : ScriptableObject
{ 
    public EntityStats stats;
    public EntityMovement movement; 
    void Start()
    { 
    }
}
 