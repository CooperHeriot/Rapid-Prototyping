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

    public Material ded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        StartPos = transform.position;

        Controller.GetComponent<BuildController>().winAmount += 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        frozen = Controller.GetComponent<BuildController>().started;

        if (Vector3.Distance(transform.position, StartPos) > 4 && dead == false && frozen == false)
        {
            dead = true;
            Controller.GetComponent<BuildController>().currentaAmount += 1;
            GetComponent<MeshRenderer>().material = ded;
        }
    }
}
