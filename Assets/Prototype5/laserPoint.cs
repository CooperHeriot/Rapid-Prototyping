using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserPoint : MonoBehaviour
{
    public GameObject laser, target;

    public GameObject firepoint;

    public LayerMask LM;

    public float dist, girth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(firepoint.transform.position, firepoint.transform.forward, out hit, dist, LM))
        {
            if (laser.active == false)
            {
                laser.SetActive(true);
                target.SetActive(true);
            }

            laser.transform.position = new Vector3((firepoint.transform.position.x + hit.point.x) / 2, (firepoint.transform.position.y + hit.point.y) / 2, (firepoint.transform.position.z + hit.point.z) / 2);

            target.transform.position = hit.point;

            laser.transform.LookAt(hit.point);

            laser.transform.localScale = new Vector3(girth, girth, Vector3.Distance(firepoint.transform.position, hit.point));
        }
        else
        {
            laser.SetActive(false);
            target.SetActive(false);
        }

            
    }
}
