using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Endscreen : MonoBehaviour
{
    [SerializeField] GameObject endscreen;

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
        endscreen.SetActive(false);
    }
     public void Home()
    {
        SceneManager.LoadScene("Main menu");
        Time.timeScale = 1;
    }
}
