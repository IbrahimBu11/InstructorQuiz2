using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
    void Move(Vector3 move)
    {
        transform.Translate(move * playerSpeed * Time.deltaTime);
    }
    void Rotation()
    {
        
        transform.LookAt(shootpoint);
    }
    
}

