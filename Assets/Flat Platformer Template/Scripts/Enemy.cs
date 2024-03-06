using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    public int enemymaxHP = 10;
    public int enemycurrentHP;
    public int enemydamage;
    public Player playerHP;
    public float speed;

public void TakeDamage(int damage)
    {
        enemycurrentHP -= enemydamage;
        
        if (enemycurrentHP <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy died.");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            playerHP.TakeDamage(enemydamage);
        }
    }

    void Start(){
       enemycurrentHP = enemymaxHP;
}
}