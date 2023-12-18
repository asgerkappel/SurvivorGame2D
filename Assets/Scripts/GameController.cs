using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool MenuOpen = false;
    public int Score = 0;
    public int HighScore = 0;
    public int Lives = 3;
    public int EnemiesSpawned = 0;
    public int EnemiesAlive = 0;
    public int EnemiesToSpawn = 0;

    private void Start()
    {
        // Initialize game state, spawn initial enemies, etc.
        InitializeGame();
    }

    private void InitializeGame()
    {
        // Your initialization code here
    }

    public void PlayerScored(int points)
    {
        Score += points;
        // Trigger events or update UI related to scoring
    }

    public void PlayerLostLife()
    {
        Lives--; 

        // Trigger events or update UI related to losing a life
    }

    public void SpawnEnemy()
    {
        // Your logic for spawning enemies
        EnemiesSpawned++;
        EnemiesAlive++;
    }

    public void EnemyDefeated()
    {
        // Your logic for handling defeated enemies
        EnemiesAlive--;
    }

    public void UpdateHighScore()
    {
        if (Score > HighScore)
        {
            HighScore = Score;
            // Save high score (you can use PlayerPrefs or another method)
        }
    }

    public void PauseGame()
    {
        // Your logic for pausing the game
        Time.timeScale = 0f; // Freeze time
        // Disable player input, show pause menu, etc.
    }

    public void ResumeGame()
    {
        // Your logic for resuming the game
        Time.timeScale = 1f; // Unfreeze time
        // Enable player input, hide pause menu, etc.
    }
}
