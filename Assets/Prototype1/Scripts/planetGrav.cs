using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetGrav : MonoBehaviour
{
    public GameObject Core;

    private Rigidbody rb;
    public float pull, pullp;
    public float dist;

    public LayerMask lay;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (Core.transform.position - transform.position).normalized;

        //transform.rotation = Quaternion.LookRotation(lookDirection);

        //RaycastHit hit;

        dist = Vector3.Distance(transform.position, Core.transform.position);

        if (dist > 16)
        {
            pullp = pull + (dist * 4);
        } else
        {
            pullp = pull;
        }

        if (Physics.Raycast(transform.position, (transform.up * -1), out RaycastHit hit, Mathf.Infinity, lay))
        {
            //Quaternion matchSurface = transform.LookAt(transform.forward, hit.normal);

            transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

/*
            Quaternion turnRot = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

            transform.rotation = Quaternion.Lerp(transform.rotation, turnRot, 1 * Time.deltaTime);*/

        }

        rb.AddForce(lookDirection * pullp);
    }
}
