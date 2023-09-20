using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] vehiclePrefabs;
    private float startDelay = 1.5f;
    private float spawnInterval = 1.5f;

    // Define the spawn position
    public float spawnPosZ = 5.0f;
    private float minX = -18.0f;
    private float maxX = 21.0f;
    private float fixedY = 0.0f; // Fixed Y-axis value to make it go along the ground

    // Start is called before the first frame update
    void Start()
    {
        // Call the SpawnRandomVehicle method repeatedly with the specified delay and interval
        InvokeRepeating("SpawnRandomVehicle", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // Your Update logic here (if needed)
    }

    // This method is now correctly defined outside of Update and Start
    void SpawnRandomVehicle()
    {
        // Generate a random index within the range of your vehiclePrefabs array
        int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);

        // Generate a random spawn position within the specified range
        Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), fixedY, spawnPosZ);

        // Retrieve the rotation of the selected prefab
        Quaternion prefabRotation = vehiclePrefabs[vehicleIndex].transform.rotation;

        // Instantiate the randomly selected prefab at the calculated position with the prefab's rotation
        Instantiate(vehiclePrefabs[vehicleIndex], spawnPos, prefabRotation);

        Debug.Log("Spawn Position: " + spawnPos);
    }
}
