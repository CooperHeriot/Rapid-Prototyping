using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camKnockoff : MonoBehaviour
{
    public Vector3 pos;
    private Quaternion startQ;
    private Rigidbody rb;

    public GameObject crack, tech;

    public float timer = 4;
    public bool knockedOff;
    // Start is called before the first frame update
    void Start()
    {
        startQ = transform.rotation;
        pos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, pos) > 2)
        {
            knockedOff = true;
        }

        if (knockedOff == true)
        {
            timer -= 1 * Time.deltaTime;

            crack.SetActive(true);

            if (timer <= 1)
            {
                tech.SetActive(true);
            }

            if (timer <= 0)
            {
                crack.SetActive(false);
                tech.SetActive(false);

                timer = 3;

                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;

                transform.position = pos;
                transform.rotation = startQ;

                knockedOff = false;
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.tag == "bump")
        {
            knockedOff = true;
        }
    }
}
