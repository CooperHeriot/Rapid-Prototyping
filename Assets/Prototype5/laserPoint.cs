using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserPoint : MonoBehaviour
{
    public GameObject laser;

    public GameObject firepoint;

    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(firepoint.transform.position, firepoint.transform.forward, dist))
        {
            if (laser.active == false)
            {

            }
        }
        else
        {
            laser.SetActive(false);
        }

            
    }
}
