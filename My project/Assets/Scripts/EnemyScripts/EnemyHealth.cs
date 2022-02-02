using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

   

    public int startingHealth = 120;
    public int health;

    public GameObject ScoreManager;

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
        if(transform.position.y < -2)
        {
            Destroy(gameObject);
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().IncreaseScore();
        }
        if (health <= 0)
        {
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().IncreaseScore();
            

            Destroy(gameObject);

        }
    }
}
