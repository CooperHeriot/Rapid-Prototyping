using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehav : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movementVector = new Vector3(x, 0, y);

        rb.AddForce((movementVector * speed));
    }
}
