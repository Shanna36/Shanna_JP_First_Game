using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables 
    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
   private float forwardInput;
   public string inputId;

   public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey; 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    //vehicle moves forward based on delta time
    void Update()
    {
       //This is where we get player input
       horizontalInput = Input.GetAxis ("Horizontal" + inputId);
       forwardInput = Input.GetAxis ("Vertical" + inputId);

        // We move the vehicle forward
       transform.Translate (Vector3.forward * Time.deltaTime * speed * forwardInput);
       // We Turn the Vehicle 
        transform.Rotate (Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
