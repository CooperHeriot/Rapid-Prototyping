using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetGrav : MonoBehaviour
{
    public GameObject Core;

    private Rigidbody rb;
    public float pull;
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

        if (Physics.Raycast(transform.position, (transform.up * -1), out RaycastHit hit, Mathf.Infinity))
        {
            //Quaternion matchSurface = transform.LookAt(transform.forward, hit.normal);

            transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

        }

        rb.AddForce(lookDirection * pull);
    }
}
