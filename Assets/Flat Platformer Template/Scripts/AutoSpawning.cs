using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawning : MonoBehaviour{

    public GameObject enemy;
    public int xPos;
    public int yPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop(){
        GameObject cart = GameObject.FindObjectOfType<Cart>().gameObject;
        while(enemyCount < 3){
        do {
            xPos = Random.Range(-37, 55);
        } while (Vector2.Distance(cart.transform.position, new Vector2(xPos, -40)) <= 10);
        Instantiate(enemy, new Vector2(xPos, -40), Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        enemyCount += 1;
        }   
    }
}