using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileTravelSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = projectileTravelSpeed * Vector3.forward * Time.deltaTime;
    }
}
