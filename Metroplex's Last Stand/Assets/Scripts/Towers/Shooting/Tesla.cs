using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesla : MonoBehaviour
{
    public List<GameObject> enemiesInRange;

    void Update()
    {
        foreach (GameObject enemy in enemiesInRange)
        {
            //get get damage script
            //use lose health void
        }
    }
}
