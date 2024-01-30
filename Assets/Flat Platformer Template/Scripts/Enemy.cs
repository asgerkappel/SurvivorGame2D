using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    public int health;
    public int currentHP;
    public int damage;
    public Player playerHP;
    public float speed;

public void TakeDamage(int damage)
    {
        currentHP -= damage;
        
        // Her kan du tilføje yderligere logik, fx spilleren dør, hvis HP når nul.
        if (currentHP <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy died.");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            playerHP.TakeDamage(damage);
        }
    }

    void Start(){
       
}
}