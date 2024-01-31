using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    public int maxHP = 10;
    public int currentHP;
    public int damage;
    public Player playerHP;
    public float speed;

public void TakeDamage(int damage)
    {
        currentHP -= damage;
        
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
       currentHP = maxHP;
}
}