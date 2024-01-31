using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour
{
    public float speed = 1.0f; // Speed of the cart

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the cart forward and to the right
        transform.Translate(new Vector3(1, 0, 1) * speed * Time.deltaTime);
    }
}