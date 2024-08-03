using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTarget : MonoBehaviour
{
    // The values below were selected and tweaked during game mode
    private float xRange = 3.5f;
    private float ySpawnPosition = -2;
    float speed = 12;

    Rigidbody appleRb;

    // Start is called before the first frame update
    void Start()
    {
        appleRb = GetComponent<Rigidbody>(); // get the rigidbody component on the apple without having to access it publicly

        appleRb.AddForce(RandomForce(), ForceMode.Impulse);
        transform.position = RandomSpawnPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Detroy apple on click
    private void OnMouseDown() {
        Destroy(gameObject);
    }


    // Generate random position
    private Vector3 RandomSpawnPosition() {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPosition, -4);
    }

    // Generate random force
    private Vector3 RandomForce() {
        return Vector3.up * Random.Range(speed, speed+4);
    }
}
