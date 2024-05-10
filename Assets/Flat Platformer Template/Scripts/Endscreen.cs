using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Endscreen : MonoBehaviour
{
    [SerializeField] GameObject endscreen;

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
        endscreen.SetActive(false);
        Killcount.KillcountValue = 0;
    }
     public void Home()
    {
        SceneManager.LoadScene("Main menu");
        Time.timeScale = 1;
    }
}
