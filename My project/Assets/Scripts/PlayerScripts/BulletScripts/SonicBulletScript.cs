using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicBulletScript : MonoBehaviour
{
    public float speed = 30f;
    public int damage = 30;
    public float power = 8;
    Vector3 rot;

    void Start()
    {
        rot = transform.rotation.eulerAngles;
        rot.x = 0;
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.rotation = Quaternion.Euler(rot);
        transform.localScale += Vector3.one * Time.deltaTime;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * power, ForceMode.Impulse);
            collision.gameObject.GetComponent<Health>().Dodamage(damage);
            Debug.Log("Sonic Attack working");
        }
    }

}
