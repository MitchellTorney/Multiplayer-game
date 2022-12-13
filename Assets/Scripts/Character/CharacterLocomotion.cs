
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterLocomotion  : MonoBehaviour
{
    #region globalvariables   
        #region  charactermovementstuff 
            float speed;
            float maxSpeed;  
            float JumpHeight;
        #endregion
        #region gravitystats
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
        characterStateManager = GetComponent<CharacterStateManager>(); 
        animator = GetComponentInChildren<Animator>(); 

    }
    
    void Start()
    {
        
        speed = entity.movement.BaseSpeed;
        maxSpeed = entity.movement.MaxSpeed;
        Debug.Log("yer speed is " + speed);
    }
      
    void Update()
    {
        movingcontrols(); 
        gravity();      
        input.controller.Move(velocity * Time.deltaTime );     
    }
 
    
    void gravity()
    {
         
    switch(entity.movement.IdentifyMovementType)
        {       
                case "Regular":
                velocity.y += entity.movement.Weight *Time.deltaTime;
                Debug.Log("Your movement type is: Regular and " + velocity.y);                
                        if(characterStateManager.isGrounded && velocity.y < 0)
                        {
                            velocity.y = -2f;        
                        }    
                break;
                case "Glider":
                Debug.Log("Your movement type is: Glider" + JumpHeight );                
                        while(characterStateManager.isGrounded && velocity.y < 0)
                                    {
                                        velocity.y = -2f;  
                                    }
                break;

        }
          


         
    }

  
      void movingcontrols()
    {  
        Vector3 move = transform.right * input.x + transform.forward * input.z;
        input.controller.Move(move * speed * Time.deltaTime);
        velocity.y += entity.movement.Weight * Time.deltaTime;
        input.controller.Move(move * Time.deltaTime ); 
        float mag = Mathf.Clamp01(new Vector2(input.z, input.x).magnitude)*maxSpeed;
        
        animator.SetBool("isRunning", Input.GetAxisRaw("Vertical") != 0);
        animator.SetFloat("Velocity.x", mag); 
       
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