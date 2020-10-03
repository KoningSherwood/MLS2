using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float shotTimer;
    public bool tesla;
    public float fireRate;
    public GameObject projectile;
    public GameObject firedProjectile;
    public float projectileTravelSpeed;
    public Targeting targeting;
    public Transform shotPoint;
    public bool Buffed;

    void Start()
    {
        targeting = GetComponent<Targeting>();
        if (tesla == true)
        {
            targeting.tesla = true;
        }
        if(projectile != null)
        {
            projectile.GetComponent<Projectile>().projectileTravelSpeed = projectileTravelSpeed;
        }
    }

    void Update()
    {
        shotTimer += Time.deltaTime;
        if(tesla == false)
        {
            if(shotTimer >= fireRate && targeting.currentTarget != null)
            {
                firedProjectile = Instantiate(projectile, shotPoint.position, Quaternion.identity);
                firedProjectile.GetComponent<Projectile>().LookAtTarget(targeting.currentTarget);
                shotTimer = 0;
            }
        }
        else
        {
            if (shotTimer >= fireRate && targeting.enemiesInRange.Count > 0)
            {
                foreach (GameObject enemy in targeting.enemiesInRange)
                {
                    // get health script
                    // use damage void
                }
                    shotTimer = 0;
            }
        }
    }

    public void BuffUp(float attackSpeedBuff, float attackDamageBuff)
    {
        if(Buffed == true)
        {
            fireRate -= fireRate * attackSpeedBuff;
        }
    }
}