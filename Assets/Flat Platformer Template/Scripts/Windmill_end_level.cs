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
            UnlockedNewLevel();
            
            // Load the next scene in the build order
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //SceneController().instance.NextLevel();
        }
    }

    void UnlockedLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", + 1) + 1);
            PlayerPrefs.Save();
        }
    }






}