using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Windmill_end_level : MonoBehaviour
{
    [SerializeField] GameObject endscreen;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Cart"))
        {
            UnlockedNewLevel();
            Time.timeScale = 0;
            endscreen.SetActive(true);
        }
    }

    void UnlockedNewLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", + 1) + 1);
            PlayerPrefs.Save();
        }
    }

}