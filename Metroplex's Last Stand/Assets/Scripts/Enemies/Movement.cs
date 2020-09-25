using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform target;
    public Transform cp1;
    public Transform cp2;
    public Transform cp3;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            if (target == cp3)
            {
                Destroy(gameObject);
            }

            if (target == cp2)
            {
                target = cp3;
            }

            if (target == cp1)
            {
                target = cp2;
            }
        }

        transform.LookAt(target);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
