
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestCharacterLocomotion  : MonoBehaviour
{
    #region globalvariables   
        #region  charactermovementstuff
            public CharacterController controller;
            float speed;
            float maxSpeed;  
            float JumpHeight;
        #endregion
        #region charactergravity
            bool canjump;
            bool jumpingCurrently;
            bool firstHit;    
            Vector3 velocity;  
        #endregion  
    
    #endregion  
        #region ImportedClasses
            public CharacterInputHandler input;
            public Entity entity;
            public CharacterStateManager characterStateManager;
            public Animator animator; 
        #endregion
    

 
    void Awaken()
    {    
        input = GetComponent<CharacterInputHandler>(); 
        controller = GetComponent<CharacterController>();
        characterStateManager = GetComponent<CharacterStateManager>(); 
        animator = GetComponentInChildren<Animator>(); 
    }
    
      
    void Update()
    {
        movingcontrols();       
    }
 
      

  
      void movingcontrols()
    {  
        input.z = Input.GetAxis("Vertical");
        input.x = Input.GetAxis("Horizontal");
        Vector3 move = transform.right * input.x + transform.forward * input.z;
        controller.Move(move * speed * Time.deltaTime);
        velocity.y += entity.movement.Weight * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime );
        //Handles animation
        animator.SetBool("isRunning", Input.GetAxisRaw("Vertical") != 0);
        float mag = Mathf.Clamp01(new Vector2(input.z, input.x).magnitude)*maxSpeed;
        animator.SetFloat("Velocity.x", mag);
        //Handles jumping
       
    }
 
     

}
/*
    void FallDamage()

    {
            if (!characterStateManager.isGrounded && characterStateManager.fallTime > falldmgInitializer * Time.deltaTime)
            {
                firstHit = true; 
                Debug.Log("Fall damage triggered");
            } 
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {     
            if (firstHit == true && hit.gameObject.layer == 6 )
            {
            Debug.Log("YOUD TAKE A HIT");
             
               
                PlayerHealth = (PlayerHealth.value - fallTime);
                Debug.Log("Health is: " + PlayerHealth); 
              
                firstHit = false; 
            } 
            characterStateManager.fallTime = 0f;
      */