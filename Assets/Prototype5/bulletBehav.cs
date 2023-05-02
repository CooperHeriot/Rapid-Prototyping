using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehav : MonoBehaviour
{
    public float force;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * force, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
