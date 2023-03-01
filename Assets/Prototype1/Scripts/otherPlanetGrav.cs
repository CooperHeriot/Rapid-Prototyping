using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherPlanetGrav : MonoBehaviour
{
    public GameObject Core;

    private Rigidbody rb;
    public float pull;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Core = GameObject.Find("Planet");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 lookDirection = (Core.transform.position - transform.position).normalized;

        rb.AddForce(lookDirection * pull);
    }
}
