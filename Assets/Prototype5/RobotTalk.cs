using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotTalk : MonoBehaviour
{
    public bool done = false;
    public OnNear ON;
    public float dist2, r2;

    public robotTalkCounter RT;
    // Start is called before the first frame update
    void Start()
    {
        ON = GetComponent<OnNear>();

        RT = FindObjectOfType<robotTalkCounter>().GetComponent<robotTalkCounter>();

        RT.maxRob += 1;
    }

    // Update is called once per frame
    void Update()
    {
        dist2 = ON.dist;
        r2 = ON.radius;

        if (ON.dist <= ON.radius && done == false)
        {
            RT.currentRob += 1;
            done = true;
        }
    }
}
