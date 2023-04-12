using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ghostUltimatum : MonoBehaviour
{
    public TextMeshProUGUI TP;
    public GhostFinder Gf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 10)){ 
            if (hit.transform.tag == "ghost" && Gf.HoldP == true)
            {
                TP.text = ("boo");
            } else
            {
                print("zaza");
            }

            
        }
    }
}
