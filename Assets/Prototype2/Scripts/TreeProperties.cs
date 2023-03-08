using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum branchesAmount { b1, b2, b3 }
//public enum branchesRight { right1, right2, right3 }
public enum Sap { YellowSa, BlueSa, RedSa }
public enum Animal { Owl, Crow }
public class TreeProperties : GameBehaviour
{
    public int BL, BR;

    public Sap sape;

    public bool attract;
    public Animal anml;

    // Start is called before the first frame update
    void Start()
    {
        BL = Random.Range(0, 4);
        BR = Random.Range(0, 4);

        sape = RandomEnum<Sap>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
