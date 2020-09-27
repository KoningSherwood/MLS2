using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float shotTimer;
    public float fireRate;
    public GameObject projectile;
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
            Instantiate(projectile, shotPoint.position, new Quaternion(0,0,0, Quaternion.identity.w));
            shotTimer = 0;
        }
    }
}