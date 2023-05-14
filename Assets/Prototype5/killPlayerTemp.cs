using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayerTemp : MonoBehaviour
{
    public giantWalk GW;
    public GiantAttack GA;

    public FacePlayer FP;

    public GameObject Bar;
    // Start is called before the first frame update
    void Start()
    {
        GW.engaged = true;
        GA.enabled = true;
        FP.enabled = true;
        Bar.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
