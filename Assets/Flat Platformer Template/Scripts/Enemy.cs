using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    public int health;
    public int currentHP;
    public int damage;
    public Player playerHP;

    private void onCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            playerHP.TakeDamage(damage);
        }
    }

    void Start(){
       
}
}