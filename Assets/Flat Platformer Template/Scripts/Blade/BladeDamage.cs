using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class BladeDamage : MonoBehaviour
{
    public int damage;
    public Enemy enemyHP;
    public BladeSwing bladeSwing; // Reference to the BladeSwing script
    public BoxCollider2D bladeCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the BladeSwing is active and the collided object is an enemy
        if(bladeSwing.anim.GetCurrentAnimatorStateInfo(0).IsName("BladeAttack") && collision.gameObject.tag == "Enemy")
        {
            enemyHP.TakeDamage(damage);
        }
    }

    public void EnableCollider()
    {
        bladeCollider.enabled = true;
    }

    public void DisableCollider()
    {
        bladeCollider.enabled = false;
    }
}