using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 StartPos;
    public bool frozen, dead, once, once2;

    public float dist;

    public GameObject Controller;

    public Material ded;

    public GameObject dust;
    // Start is called before the first frame update
    void Start()
    {
        once = true;
        once2 = false;
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        //StartPos = transform.position;

        Controller.GetComponent<BuildController>().winAmount += 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        frozen = Controller.GetComponent<BuildController>().started;

        if (frozen == false)
        {
            setDest();
        }

        if (Vector3.Distance(transform.position, StartPos) > 4 && dead == false && frozen == false)
        {
            dead = true;
            Controller.GetComponent<BuildController>().currentaAmount += 1;
            GetComponent<MeshRenderer>().material = ded;
        }
    }

    public void setDest()
    {
        if (once == true)
        {
            rb.isKinematic = false;
            StartPos = transform.position;

            once = false;
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (once2 == false)
        {
            Instantiate(dust, transform.position, transform.rotation);
            once2 = true;
        }
        
    }
}
