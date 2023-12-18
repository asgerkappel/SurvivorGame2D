using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
     public float WalkSpeed;
    public float JumpForce;
    public AnimationClip _walk, _jump;
    public Animation _Legs;
    public Transform _Blade, _GroundCast;
    public Camera cam;
    public bool mirror;

    public int maxHP = 100;
    private int currentHP;
    public int damage = 10; // Skade forårsaget af fjenden
   

    private void Update()
    {
        MoveEnemy(); // Kald funktionen for fjendens bevægelse
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.TakeDamage(damage); // Skade påføres spilleren ved kollision med fjenden
            }
        }
    }

    private void MoveEnemy()
    {
        // Implementer logik for fjendens bevægelse her
        // Dette kan omfatte brug af Rigidbody2D og MovePosition for at bevæge fjenden mod spilleren eller i et forudbestemt mønster.
    }
}

