using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour, IDamageable
{
    public int enemymaxHP = 10;
    public int enemycurrentHP;
    public int enemydamage;
    public Player playerHP;
    public float speed;
    public Cart cartHP;
    private Transform wagonTransform;
    public float swingSpeed = 1f;
    public Transform swordTransform;

    void Start(){
       enemycurrentHP = enemymaxHP;
       wagonTransform = GameObject.FindGameObjectWithTag("Cart").transform;
       StartCoroutine(SwingSword());
    }

    IEnumerator SwingSword(){
        while(true){
            swordTransform.rotation = Quaternion.Euler(0, 0, 0);
            swordTransform.Rotate(0, 0, 55);
            yield return new WaitForSeconds(swingSpeed);
            swordTransform.Rotate(0, 0, -55);
            yield return new WaitForSeconds(swingSpeed);

        }
    }
public void TakeDamage(int damage)
    {
        enemycurrentHP -= enemydamage;
        
        if (enemycurrentHP <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Enemy died.");
            Killcount.KillcountValue += 1;
        }
    }
    void Update(){
        // Move towards the wagon
        transform.position = Vector2.MoveTowards(transform.position, wagonTransform.position, speed * Time.deltaTime);
        Vector3 direction = wagonTransform.position - transform.position;
    }


    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            playerHP.TakeDamage(enemydamage);
        }
        if(collision.gameObject.tag == "Cart"){
            cartHP.TakeDamage(enemydamage);
        }
    }
}