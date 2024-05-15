using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUps powerUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        powerUp.apply(collision.gameObject);
        Destroy(gameObject);
    }
}