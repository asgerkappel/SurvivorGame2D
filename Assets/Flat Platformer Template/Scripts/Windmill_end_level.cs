using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Windmill_end_level : MonoBehaviour
{
    
    // Example of detecting player interaction using OnTriggerEnter
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Cart"))
        {
            Debug.Log("Level completed!");
       
            UnityEngine.SceneManagement.SceneManager.LoadScene("endscreen");
        }
    }
}