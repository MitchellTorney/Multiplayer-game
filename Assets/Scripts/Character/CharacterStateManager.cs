using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateManager : MonoBehaviour
{   
    public bool isGrounded;

   
    public Entity entity; 
     
    #region charactergravity
            bool canjump;
            bool jumpingCurrently;
            bool firstHit; 
            private float groundDistance = 0.5f;
            public LayerMask groundMask; 
            Vector3 velocity;
            [SerializeField] private Transform groundCheck;  
    
    #endregion


    void Update(){
        AmIGrounded(); 
        if (AmIGrounded() == true)
        {
        Debug.Log ("True");
        }
    }
    public bool AmIGrounded ()
    {   
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if  (isGrounded == true)
        { 
        
        return true; 
        }
        else { 
        return false; 
        }
    }
    /* 
    
 
    public void sideways(float y)
    {
        
         z = Input.GetAxis("Vertical");
         x = Input.GetAxis("Horizontal"); 
    } 
    */ 
    // Update is called once per frame 
}
