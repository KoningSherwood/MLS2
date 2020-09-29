using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToBuffTurret : MonoBehaviour
{
    public string buffTurretName;

    public void OnTriggerEnter(Collider o)
    {
        if(o.gameObject.tag == buffTurretName && gameObject.tag != buffTurretName)
        {
            o.gameObject.GetComponent<BuffTowers>().turretsInRange.Add(gameObject);
        }
    }

    public void OnTriggerExit(Collider o)
    {
        if (o.gameObject.tag == buffTurretName && gameObject.tag != buffTurretName)
        {
            o.gameObject.GetComponent<BuffTowers>().turretsInRange.Remove(gameObject);
        }
    }
}