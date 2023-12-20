using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public int damage = 100; 
    // rotation på x-aksen
    public float xRotation = 0f;
    
    void Update()
    {
        // Roter klingen omkring x-aksen
        transform.Rotate(new Vector3(1, 0, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        // Hvis klingen rammer en fjende, så skal fjenden tage skade
        if (other.CompareTag("Enemy"))
        {
            // Hent fjendens script
            Enemies enemy = other.GetComponent<Enemies>();
            
            // Hvis fjenden har et script, så påfør skade
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }



}