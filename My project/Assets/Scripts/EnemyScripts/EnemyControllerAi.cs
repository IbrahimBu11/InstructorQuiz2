using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerAi : MonoBehaviour
{
    public Transform targetPlayer;
    public float speed = 20f;
    public int damage = 10;

    public Health health;


    void Start()
    {
        health = GetComponent<Health>();
        targetPlayer =GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetPlayer);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Health>().Dodamage(damage);
            Destroy(gameObject);
        }
    }

}
