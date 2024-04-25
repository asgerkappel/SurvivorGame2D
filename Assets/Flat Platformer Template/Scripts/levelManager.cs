using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Function to complete the level
    public void CompleteLevel()
    {
        // Display the end screen or perform any other actions you want to happen when the level is completed
        Debug.Log("Level completed!");
        // For example, you could load a new scene or show a UI screen
        // SceneManager.LoadScene("EndScreen"); // Uncomment this line if you're using SceneManager
        // UIManager.ShowEndScreen(); // Uncomment this line if you're using a UI manager
    }
}
