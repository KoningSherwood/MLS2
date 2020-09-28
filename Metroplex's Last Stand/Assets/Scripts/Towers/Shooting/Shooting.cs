using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float shotTimer;
    public float fireRate;
    public GameObject projectile;
    public GameObject firedProjectile;
    public float projectileTravelSpeed;
    public Targeting targeting;
    public Transform shotPoint;

    void Start()
    {
        targeting = GetComponent<Targeting>();
        if(projectile != null)
        {
            projectile.GetComponent<Projectile>().projectileTravelSpeed = projectileTravelSpeed;
        }
    }

    void Update()
    {
        shotTimer += Time.deltaTime;
        if(shotTimer >= fireRate && targeting.currentTarget != null)
        {
            firedProjectile = Instantiate(projectile, shotPoint.position, Quaternion.identity);
            firedProjectile.GetComponent<Projectile>().LookAtTarget(targeting.currentTarget);
            shotTimer = 0;
        }
    }
}