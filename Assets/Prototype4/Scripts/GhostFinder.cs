using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFinder : MonoBehaviour
{
    public bool HoldP;
    public Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            HoldP = true;
        } else
        {
            HoldP = false;
        }

        if (HoldP == true)
        {
            Anim.Play("Use");
        } else
        {
            Anim.Play("unUse");
        }
    }
}
