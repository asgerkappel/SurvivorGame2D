using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carthjul : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // Speed of the wheel rotation

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the wheel in the same tempo as the cart but in the opposite direction
        transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}