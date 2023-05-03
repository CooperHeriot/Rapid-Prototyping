using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamtTooClose : MonoBehaviour
{
    public GameObject Modl, Sprit;
    private Renderer ren;
    public float thresh;
    // Start is called before the first frame update
    void Start()
    {
        ren = Modl.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Modl.transform.position) <= thresh)
        {
            ren.enabled = false;
            Sprit.SetActive(true);
        } else
        {
            ren.enabled = true;
            Sprit.SetActive(false);
        }
    }
}
