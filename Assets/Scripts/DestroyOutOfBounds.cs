using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //define your game boundaries
    private float lowerBound = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if (transform.position.z < -lowerBound) //if vehicle position is less than -50 on z axis, destroy
        {
             Destroy (gameObject);
        }
        
    }
}
