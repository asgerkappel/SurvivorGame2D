using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMillMål : MonoBehaviour
{
    
//private audiosource WindMillMållyd; 

    /*private void Start()
    {
        WindMillMållyd = GetComponent<AudioSource>();
    }*/

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "cart")
        {
            //WindMill_0.Play();
            completeLevel();
        }

    }

    private void completeLevel()
    {
        Debug.Log("Level Complete");
    }

}
