using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHealth : MonoBehaviour
{
    public float maxHealth;
    public GameObject nodeUnderTurret;
    
    void Update()
    {
        maxHealth -= Time.deltaTime;

        if(maxHealth <= 0)
        {
            TurretDeath();
        }
    }

    public void TurretDeath()
    {
        nodeUnderTurret.GetComponent<BuildingCheck>().turret = null;
        Destroy(gameObject);
    }
}