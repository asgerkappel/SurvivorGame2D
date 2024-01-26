using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeSwing : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        // Get the Animator component attached to the game object
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // If the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Activate the animator
            anim.SetTrigger("BladeAttack");
        }
    }
}