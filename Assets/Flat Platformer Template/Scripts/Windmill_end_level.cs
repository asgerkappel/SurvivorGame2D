using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windmill_end_level : MonoBehaviour
{
    // Reference to the level manager
    public LevelManager levelManager;

    // Example of detecting player interaction using OnTriggerEnter
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Cart"))
        {
            // Call the CompleteLevel function in the level manager
            levelManager.CompleteLevel();
        }
    }
}