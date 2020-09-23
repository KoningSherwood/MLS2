using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEnemyToTargeting : MonoBehaviour
{
    public string nameTurretTag;

    public void OnTriggerEnter(Collider o)
    {

        if (o.gameObject.tag == nameTurretTag)
        {
            o.gameObject.GetComponent<Targeting>().enemiesInRange.Add(gameObject);
        }
    }

    public void OnTriggerExit(Collider o)
    {
        if (o.gameObject.tag == nameTurretTag)
        {
            o.gameObject.GetComponent<Targeting>().enemiesInRange.Remove(gameObject);
        }
    }
}