using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int Score;
    
    public Text scoreUI;
    public Text timeUI;

    public GameObject GameWInUI;
    public int timef;

    public void IncreaseScore()
    {
        Score += 1;
    }
    // Update is called once per frame
    void Update()
    {
        timef += (int)Time.deltaTime;

        
        scoreUI.text = "Score : " + Score;
        timeUI.text = "Time : " + timef;

        if(Score > 15)
        {
            GameWInUI.SetActive(true);
            if (Input.GetKey(KeyCode.R))
                SceneManager.LoadScene(0);
        }
        if (Time.deltaTime >= 60)
            GameObject.Find("Player").GetComponent<Health>().gameOver = true;
    }
}
