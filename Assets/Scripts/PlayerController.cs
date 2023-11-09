using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables 
    //[SerializeField] private float speed = 20.0f;
    [SerializeField] private float horsePower = 0f;
    [SerializeField]  private float turnSpeed = 25.0f;
    private float horizontalInput;
   private float forwardInput;
   public string inputId;

   public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey; 
    private Rigidbody playerRb;

    // Start is called before the first frame update
   void Start()
   {
    playerRb = GetComponent<Rigidbody>();
   }

    //vehicle moves forward based on delta time
    void FixedUpdate() {
        

    {
       //This is where we get player input
       horizontalInput = Input.GetAxis ("Horizontal" + inputId);
       forwardInput = Input.GetAxis ("Vertical" + inputId);

        // We move the vehicle forward
       //transform.Translate (Vector3.forward * Time.deltaTime * speed * forwardInput);
       playerRb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
       // We Turn the Vehicle 
        transform.Rotate (Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
    }
}
