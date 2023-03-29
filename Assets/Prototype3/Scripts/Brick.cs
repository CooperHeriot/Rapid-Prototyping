using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 StartPos;
    public bool frozen, dead;

    public float dist;

    public GameObject Controller;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, StartPos) > 3)
        {
            dead = true;
        }
    }
}
