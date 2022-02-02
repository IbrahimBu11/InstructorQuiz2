using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileGunBehavior : GunBehavior
{
    public GameObject ProjectileBullet;
    public Transform ProjectileShooter;
   // private bool canShoot = true;



    [SerializeField]
    private float timeDelay;
    [SerializeField]
    private float nextDamageEvent;
    [SerializeField]
    private float damage;

    public override void OnActionTriggeredFunc(float timeDelay, float damage)
    {
        
        
            
            if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time >= nextDamageEvent)
            {
                Fire();
                nextDamageEvent = Time.time + timeDelay;

            }

    }
    //public IEnumerator ShootDelay(float timeDelay)
    //{
    //    canShoot = false;
    //    yield return new WaitForSeconds(timeDelay);
    //    canShoot = true;
    //}
    public override void Fire()
    {
        //base.Fire();
        Instantiate(ProjectileBullet, ProjectileShooter.position, ProjectileShooter.transform.rotation);
        Debug.Log("Override works");

    }
}
