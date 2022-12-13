using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInputHandler : MonoBehaviour
{
    
    public CharacterController controller;
    public float x;
    public float z; 
    private float mouseX;
    private float mouseY;
    public float mouseSensitivity = 100f;
    [SerializeField] private Camera cam;
    private float xRotation = 0f; 
    [SerializeField] Transform playerBody;

    void Start()
    {     
    controller = GetComponent<CharacterController>();  
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;

    }

    public void Update()
    {
    z = Input.GetAxis("Vertical");
    x = Input.GetAxis("Horizontal");
    
    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

    xRotation -= mouseY;
    xRotation = Mathf.Clamp(xRotation, -90f, 90f); 
    cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    
    playerBody.Rotate(Vector3.up * mouseX);

    }
}
