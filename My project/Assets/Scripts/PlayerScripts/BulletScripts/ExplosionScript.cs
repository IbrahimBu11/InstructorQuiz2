using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 10.0F;
    public Rigidbody rb;
    public int  damage = 80;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Explode();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Explode()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null) { 
                rb.AddForce(Vector3.right * power, ForceMode.Impulse);
                rb.gameObject.GetComponent<Health>().Dodamage(damage);
            }
        }
    }
}
