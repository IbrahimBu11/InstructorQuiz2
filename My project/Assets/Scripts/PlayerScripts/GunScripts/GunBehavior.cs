using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour
{
    
    public Transform shootpos;
    
    private float timeDelay;
    
    private float damage;

    //Common gun behavior
    private void Update()
    {
        OnActionTriggeredFunc(timeDelay, damage);
    }
    public virtual void OnActionTriggeredFunc(float timeDelay, float damage)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
            //StartCoroutine(ShootDelay(timeDelay));           
        }
    }
    
    public virtual void Fire()
    {
        Debug.Log("No works");
    }
}
