using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeting : MonoBehaviour
{
    public bool tesla;
    public GameObject turretHead;
    public GameObject turretStand;
    public GameObject currentTarget;
    public int Range;
    public List<GameObject> enemiesInRange;

    void Awake()
    {
        GetComponent<SphereCollider>().radius = Range;
    }

    void Update()
    {
        if(tesla == false)
        {
            if(currentTarget == null && enemiesInRange.Count > 0)
            {
                currentTarget = enemiesInRange[0];
            }

            if(currentTarget != null)
            {
                turretHead.transform.LookAt(currentTarget.transform);
                turretStand.transform.rotation = new Quaternion (0, turretHead.transform.rotation.y, 0, turretStand.transform.rotation.w);
            }
        }
    }
}