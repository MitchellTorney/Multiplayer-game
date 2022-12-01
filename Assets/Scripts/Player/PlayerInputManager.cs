using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{   
    public float z;
    public float x;

    public float rb_Input;
 
    public void sideways(float y)
    {
        
         z = Input.GetAxis("Vertical");
         x = Input.GetAxis("Horizontal"); 
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
