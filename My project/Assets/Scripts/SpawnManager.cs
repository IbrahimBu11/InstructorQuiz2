using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemies;
    public Transform[] spawnlocations;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 2f, 5);
    }

    void SpawnEnemies()
    {
        int random = Random.Range(0, 2);
        for (int i = 0; i < Random.Range(2,5); i++)
        {
            Instantiate(enemies, spawnlocations[random].position, enemies.transform.rotation);
        }
    }
}
