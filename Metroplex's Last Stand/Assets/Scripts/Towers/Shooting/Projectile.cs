using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileTravelSpeed;

    void Update()
    {
        transform.Translate(projectileTravelSpeed * Vector3.forward * Time.deltaTime);
    }

    public void LookAtTarget(GameObject target)
    {
        transform.LookAt(target.transform);
    }
}
