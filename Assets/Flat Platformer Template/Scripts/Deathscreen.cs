using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Deathscreen : MonoBehaviour
{
    [SerializeField] GameObject deathscreen;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        deathscreen.SetActive(false);
    }
     public void Home()
    {
        SceneManager.LoadScene("Main menu");
        Time.timeScale = 1;
    }
}
