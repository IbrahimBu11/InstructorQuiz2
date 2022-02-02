using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantGunBeavior : GunBehavior
{
    public GameObject InstantExplode;
    private bool canShoot = true;



    [SerializeField]
    private float timeDelay;
    [SerializeField]
    private float damage;

    public override void OnActionTriggeredFunc(float timeDelay, float damage)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canShoot)// && //canShoot)
        {
            Fire();
            StartCoroutine(ShootDelay(timeDelay));
            
        }

    }
    public IEnumerator ShootDelay(float timeDelay)
    {
        canShoot = false;
        yield return new WaitForSeconds(timeDelay);
        canShoot = true;
    }

    public override void Fire()
    {
        //base.Fire();
        Destroy(Instantiate(InstantExplode, shootpos.position, InstantExplode.transform.rotation), 1f);
        Debug.Log("Override works");

    }
}
