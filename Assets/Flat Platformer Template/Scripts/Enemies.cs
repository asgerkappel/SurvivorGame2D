using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemies : MonoBehaviour
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

    // Referencer
    public Blade blade;

    // Metode til at tage skade
    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        // Her kan du tilføje yderligere logik, fx spilleren dør, hvis HP når nul.
        if (currentHP <= 0)
        {
            // slet fjenden, hvis den dør
            Die();
        }
    }

    private void Die()
    {
        // Slet fjenden, når den dør
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Blade")) // Antag, at klingen har en tag kaldet "Blade"
        {
            // Hent skadeværdien fra klingen og påfør fjenden skaden
            TakeDamage(collision.gameObject.GetComponent<Blade>().damage);
        }
    }

    private void Update()
    {
        MoveEnemy(); // Kald funktionen for fjendens bevægelse
    }

    private void MoveEnemy()
    {
        // Implementer logik for fjendens bevægelse her
        // Dette kan omfatte brug af Rigidbody2D og MovePosition for at bevæge fjenden mod spilleren eller i et forudbestemt mønster.
    }
}
