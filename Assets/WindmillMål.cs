using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillMål : MonoBehaviour
{
    
private audiosource Mållyd; 

    void Start()
    {
        Mållyd = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other{
        if (collision.gameObject.tag == "cart")
        {
            Mållyd.Play();
            completeLevel();
        }

    }

    private void completeLevel()
    {
        Debug.Log("Level Complete");
    }

}
