using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float shotTimer;
    public float fireRate;
    public GameObject projectile;
    public float projectileTravelSpeed;

    void Start()
    {
        if(projectile != null)
        {
            projectile.GetComponent<Projectile>().projectileTravelSpeed = projectileTravelSpeed;
        }
    }

    void Update()
    {
        
    }
}