using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public enum Operations { add, sub, mult, div }

public class WhatAmI : MonoBehaviour
{
    public bool add, sub, mult, div, evil;

    public GameObject doorr, winPart;
    private Door dr;
    //public bool 
    //public Operations me;
    // Start is called before the first frame update
    void Start()
    {
        if (evil != true)
        {
            dr = doorr.GetComponent<Door>();
            /*if (me == Operations.add)
            {

            }*/
            if (add == true)
            {
                dr.ads += 1;
            }
            if (sub == true)
            {
                dr.sbs += 1;
            }
            if (mult == true)
            {
                dr.mls += 1;
            }
            if (div == true)
            {
                dr.dvs += 1;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dead()
    {
        if (evil != true)
        {
            
            if (add == true)
            {
                dr.ads -= 1;
            }
            if (sub == true)
            {
                dr.sbs -= 1;
            }
            if (mult == true)
            {
                dr.mls -= 1;
            }
            if (div == true)
            {
                dr.dvs -= 1;
            }
        }
        Instantiate(winPart, transform.position, transform.rotation);

        gameObject.SetActive(false);
    }
}
