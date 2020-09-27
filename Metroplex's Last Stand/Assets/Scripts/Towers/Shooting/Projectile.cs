using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileTravelSpeed;
    public Targeting targeting;

    void Awake()
    {
        
    }

    void Update()
    {
        transform.position += projectileTravelSpeed * Vector3.forward * Time.deltaTime;
    }
}
