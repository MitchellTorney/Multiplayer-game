using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInputHandler : MonoBehaviour
{
    
    public CharacterController controller;
    public float x;
    public float z; 
    void Start()
    {   
    controller = GetComponent<CharacterController>();
    InitializeMovementTypes();
    }

    void InitializeMovementTypes()
    {
                

    }
}
