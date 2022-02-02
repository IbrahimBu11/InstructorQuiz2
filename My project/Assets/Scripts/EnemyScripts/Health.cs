using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public bool gameOver = false;

    public int startingHealth = 120;
    public int health;
    
    public void Dodamage(int damage)
    {
        health -= damage;
    }
     void Start()
    {
        health = startingHealth;
    }
    void Update()
    {
        Debug.Log("Game is over : " + gameOver);
         
            if(health <= 0)
        {
            if (gameObject.name != "Player")
            {
                Destroy(gameObject);
            }
            else
                gameOver = true;
                
        }

    }

}
