using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public float speed = 10f;
    public float rotationSpeed = 100f;

    private Rigidbody carRigidbody;

    private void Awake()
    {
        carRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Get horizontal input for rotation
        float rotation = Input.GetAxis("Horizontal");

        // Rotate the car
        transform.Rotate(Vector3.up * rotation * rotationSpeed * Time.deltaTime);

        // Get vertical input for movement
        float move = Input.GetAxis("Vertical");

        // Move the car
        carRigidbody.velocity = transform.forward * move * speed;
    }


}
