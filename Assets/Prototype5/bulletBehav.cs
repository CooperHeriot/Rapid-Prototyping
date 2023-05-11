using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehav : MonoBehaviour
{
    public float force;
    private Rigidbody rb;
    public float timer;

    public bool evil;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * force, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<EnemyHealth>() != null)
        {
            collision.transform.GetComponent<EnemyHealth>().Hurt();

            Destroy(gameObject);
        }


        if (collision.transform.GetComponent<PlayerHealth>() != null && evil == true)
        {
            collision.transform.GetComponent<PlayerHealth>().hurt();

            Destroy(gameObject);
        }
    }
}
