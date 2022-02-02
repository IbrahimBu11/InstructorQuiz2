using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBulletScript : MonoBehaviour
{
    public float speed = 30f;
    public int damage = 30;
    Vector3 rot;

     void Start()
    {
        rot = transform.rotation.eulerAngles;
        rot.x = 0;
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.rotation = Quaternion.Euler (rot);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyHealth>().Dodamage(damage);
            Destroy(gameObject);
        }

    }
}
