using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

   

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
        if (health <= 0)
        {
            Destroy(gameObject);

        }
    }
}
