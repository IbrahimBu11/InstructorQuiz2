using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public GameObject gameOverUI;
    public Slider healthUI;

    public bool gameOver = false;

    public int startingHealth = 120;
    public int health;
    

    //Public method called anytime the player is damaged
    public void Dodamage(int damage)
    {
        health -= damage;
    }
    //Avoid repeating the same health on scene reload or object instantiation
     void Start()
    {
        health = startingHealth;
        gameOverUI.SetActive(false);
    }
    void Update()
    {
        Debug.Log("Game is over : " + gameOver);
        
       
        
        healthUI.value = health;

        //Only set active the game over text and allow the restart when the game is over
        if (gameOver)
         {
            gameOverUI.SetActive(true);
            if (Input.GetKey(KeyCode.R))
               SceneManager.LoadScene(0);
         }

        //if the health goes lesser than 20 gameover = true
        if (health <= 0)
        {
            gameOver = true;                        
        }

         
        

    }

}
