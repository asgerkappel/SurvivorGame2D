using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windmill_end_level : MonoBehaviour
{
    // Example of detecting player interaction using OnTriggerEnter
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            // Call the CompleteLevel function in the level manager
            Debug.Log("Player entered trigger zone");
        }
    }
}

