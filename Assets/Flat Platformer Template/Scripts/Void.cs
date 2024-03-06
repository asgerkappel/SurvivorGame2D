using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Void : MonoBehaviour{
    public Player playerHP;
    public Enemy enemyHP;
    public int damage = 1000000000;
    public int currentHP;

public void TakeDamage(int damage)
    {
        currentHP -= damage;
        
        if (currentHP <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Player died.");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            playerHP.TakeDamage(damage);
        }
        if(collision.gameObject.tag == "Enemy"){
            enemyHP.TakeDamage(damage);
        }
    }
}