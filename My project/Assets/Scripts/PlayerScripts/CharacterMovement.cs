using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CharacterMovement : MonoBehaviour
{


    private float playerSpeed = 20.0f;
    private Vector3 mousePos;

    public Transform shootpoint;
    

    
    [SerializeField]
    private float Senstivity = 3;

    private void Start()
    {
        
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Move(move);
        Rotation();

        if(transform.position.y < -2)
        {
            GetComponent<Health>().gameOver = true;
        }
    }
    void Move(Vector3 move)
    {
        transform.Translate(move * playerSpeed * Time.deltaTime);
    }
    void Rotation()
    {
        
        transform.LookAt(shootpoint);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            GetComponent<Health>().gameOver = true;
        }
            
    }

}

