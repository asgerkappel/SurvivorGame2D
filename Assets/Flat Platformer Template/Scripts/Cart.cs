using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cart : MonoBehaviour
{
    [SerializeField] GameObject deathscreen;
    public float speed = 1.0f; 
    public int CartmaxHP = 10;
    public int cartdamage = 5;
    public int CartcurrentHP;
    

    public void TakeDamage(int cartdamage)
    {
        CartcurrentHP -= cartdamage;
        
        if (CartcurrentHP <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Cart died.");
            deathscreen.SetActive(true);
            Time.timeScale = 0;
            Killcount.KillcountValue = 0;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        CartcurrentHP = CartmaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the cart forward and to the right
        transform.Translate(new Vector3(1, 0, 1) * speed * Time.deltaTime);
    }
}