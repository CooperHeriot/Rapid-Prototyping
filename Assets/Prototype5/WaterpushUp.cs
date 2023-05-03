using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterpushUp : MonoBehaviour
{
    public float power = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Rigidbody>() != null && other.transform.tag != "bullet")
        {
            other.GetComponent<Rigidbody>().AddForce(0, power, 0);
        }
    }
}
