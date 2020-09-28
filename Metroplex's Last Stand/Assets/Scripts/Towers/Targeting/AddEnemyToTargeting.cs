using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEnemyToTargeting : MonoBehaviour
{
    public string nameTurretTag;
    public string nameTeslaTag;

    public void OnTriggerEnter(Collider o)
    {

        if (o.gameObject.tag == nameTurretTag)
        {
            o.gameObject.GetComponent<Targeting>().enemiesInRange.Add(gameObject);
        }

        if (o.gameObject.tag == nameTeslaTag)
        {
            o.gameObject.GetComponent<Tesla>().enemiesInRange.Add(gameObject);
        }
    }

    public void OnTriggerExit(Collider o)
    {
        if (o.gameObject.tag == nameTurretTag)
        {
            o.gameObject.GetComponent<Targeting>().enemiesInRange.Remove(gameObject);
            if(gameObject == o.gameObject.GetComponent<Targeting>().currentTarget)
            {
                o.gameObject.GetComponent<Targeting>().currentTarget = null;
            }
        }

        if(o.gameObject.tag == nameTeslaTag)
        {
            o.gameObject.GetComponent<Tesla>().enemiesInRange.Remove(gameObject);
        }
    }
}