using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   
    // This public variable is set to the vehicle in Unity, references the vehicle's position
    public GameObject player;

    //this one offsets the camera so it is behind the car
    private Vector3  offset = new Vector3 ( 0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Late Update ensures that it updates its position after the vehicle so it doesn't shake the camera
    void LateUpdate()
    {
        //this is where we get the camera to move position, referenceing the public variable above + the offset so it is a good camera angle
        transform.position = player.transform.position + offset;
    }
}
