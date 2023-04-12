using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ghostUltimatum : MonoBehaviour
{
    public TextMeshProUGUI TP;
    public GhostFinder Gf;

    public bool once = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 10)){ 
            if (hit.transform.tag == "ghost" && Gf.HoldP == true && once == false)
            {
                EquationGenerator EG = hit.transform.gameObject.GetComponent<EquationGenerator>();
                WhatAmI Wah = hit.transform.gameObject.GetComponent<WhatAmI>();
                if (Wah.add == true)
                {
                    once = true;

                    EG.GenerateAddition();

                    TP.text = (EG.numberOne + " + " + EG.numberTwo + " = ?");
                }

                
            } else
            {
                print("zaza");
            }

            
        }
    }

    public void MoveOn()
    {

    }
}
