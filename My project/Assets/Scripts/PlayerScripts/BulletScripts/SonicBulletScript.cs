using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicBulletScript : MonoBehaviour
{
    public float speed = 30f;
    public int damage = 30;
    public float power = 100;
    Vector3 rot;

    void Start()
    {
        rot = transform.rotation.eulerAngles;
        //Keep the bullet straight 
        rot.x = 0;
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        transform.rotation = Quaternion.Euler(rot);
        //Scale with time
        transform.localScale += Vector3.one * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * power, ForceMode.Impulse);
            other.gameObject.GetComponent<EnemyHealth>().Dodamage(damage);
            Debug.Log("Sonic Attack working");
        }
    }

}
