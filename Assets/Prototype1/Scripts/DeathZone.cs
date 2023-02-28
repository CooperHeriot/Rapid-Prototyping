using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private GameObject Planet;
    private Rigidbody rb;
    public float dist, pull;

    public Light lit;
    public ParticleSystem parti;

    public float force;
    // Start is called before the first frame update
    void Start()
    {
        Planet = GameObject.Find("Planet");
        rb = GetComponent<Rigidbody>();

        rb.AddForce(Random.Range(-force, force), Random.Range(-force, force), Random.Range(-force, force), ForceMode.VelocityChange);
        ///lit = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, Planet.transform.position);


        Vector3 lookDirection = (Planet.transform.position - transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(lookDirection);


        rb.AddForce(lookDirection * pull);

        if (dist <= 13.5f)
        {
            rb.isKinematic = true;

            lit.enabled = false;
            parti.Play();

            GetComponent<DeathZone>().enabled = false;
        }
    }
}
