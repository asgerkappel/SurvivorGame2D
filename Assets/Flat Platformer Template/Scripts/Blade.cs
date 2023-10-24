using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public int damage = 10; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Tjek om objektet, som bladet kolliderer med, har en "Player"-tag
        if (other.CompareTag("Player"))
        {
            // Hent Player-komponenten på det andet objekt
            Player player = other.GetComponent<Player>();

            // Tjek om Player-scriptet blev fundet
            if (player != null)
            {
                // Kald TakeDamage-metoden i Player-scriptet med skadesværdien
                player.TakeDamage(damage);
            }
        }
        else
        {
            // Hvis bladet rammer noget andet end spilleren, kan du tilføje yderligere logik her.
            // Eksempelvis ødelæggelse eller skade på det påvirkede objekt.
            Destroy(other.gameObject);
        }
    }
}
