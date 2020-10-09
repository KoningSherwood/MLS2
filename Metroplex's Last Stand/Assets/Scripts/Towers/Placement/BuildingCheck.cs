using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCheck : MonoBehaviour
{
    public GameObject turret;
    public TowerManager towerManage;
    public bool occupied;

    void Start()
    {
        towerManage = GameObject.Find("TowerManager").GetComponent<TowerManager>();
    }

    void Update()
    {
        if (towerManage.lastPlacedTower != null)
        {
            if (towerManage.lastPlacedTower.transform.position == transform.position + towerManage.nodeOffset)
            {
                turret = towerManage.lastPlacedTower;
                turret.GetComponent<TowerHealth>().nodeUnderTurret = gameObject;
            }
        }

        if (turret != null && occupied != true)
        {
            occupied = true;
        }

        if (turret == null && occupied == true)
        {
            occupied = false;
        }
    }
}