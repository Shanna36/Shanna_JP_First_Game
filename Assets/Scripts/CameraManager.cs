using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera[] cameras; // Array to hold both cameras
    private int currentCameraIndex = 0; // Index of the currently active camera

    void Start()
    {
        // Deactivate all cameras except the main one
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }
    }

    void Update()
    {
        // Check for player input to switch cameras (e.g., using a key or button)
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Deactivate the current camera
            cameras[currentCameraIndex].gameObject.SetActive(false);

            // Increment the camera index (loop back to 0 if necessary)
            currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

            // Activate the new current camera
            cameras[currentCameraIndex].gameObject.SetActive(true);
        }
    }
}

