
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement  : MonoBehaviour
{
    #region  charactermovementstuff
    public CharacterController controller;
    public float speed = 12f;  
    
    public float maxSpeed = 12f;
    public float gravity = -9.81f; 
    public float falldmgInitializer = 800f;
    public float JumpHeight;
    #endregion
   
    #region charactergravity
    public Transform groundCheck;
    public float groundDistance = 0.5f;
    public LayerMask groundMask;
    bool isGrounded;
    bool canjump;
    bool jumpingCurrently;
    bool firstHit = false;
    float fallTime;
    float x;
    float y;
     
    float z;
    Vector3 velocity;
    
    #endregion  
    
    #region globalvariables  
    public HealthValue PlayerHealth;
    #endregion

    public Animator animator;
    public PlayerInputManager input ;
    void Start()
    {  

        animator = GetComponentInChildren<Animator>(); 
    }

     
    // Update is called once per frame
    void Update()
    {
        checkisgrounded();
        movingcontrols();      
        FallDamage();    
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
                animator.SetBool("isAttacking", true);
        }
    }
 
      

    private bool checkisgrounded()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //Checks if character is grounded
        if (isGrounded && velocity.y < 0) 
        {
            velocity.y = -4f; 
            return true;
        } 
        else 
        {
        fallTime += Time.deltaTime ;  
        return false;
        }  
    }
    
      void movingcontrols()
    {  
         z = Input.GetAxis("Vertical");
         x = Input.GetAxis("Horizontal"); 
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime );
        //Handles animation
        animator.SetBool("isRunning", Input.GetAxisRaw("Vertical") != 0);
        float mag = Mathf.Clamp01(new Vector2(z, x).magnitude)*maxSpeed;
        animator.SetFloat("Velocity.x", mag);
        //Handles jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        { 
        velocity.y += (JumpHeight);
         } 
    }
 
    void FallDamage()

    {
            if (!isGrounded && fallTime > falldmgInitializer * Time.deltaTime)
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
            PlayerHealth.value  = UnityEngine.Mathf.Round(PlayerHealth.value - fallTime);
            
                /*
                PlayerHealth = (PlayerHealth.value - fallTime);
                Debug.Log("Health is: " + PlayerHealth); 
                */
                firstHit = false; 
            } 
            fallTime = 0f;
    }
}
