using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameObject bigin;
    private giantWalk GW;

    public float count;
    // Start is called before the first frame update
    void Start()
    {
        GW = bigin.GetComponent<giantWalk>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, bigin.transform.position) <= 100)
        {
            if (count == 1)
            {
                GW.One();
            }
            if (count == 2)
            {
                GW.Two();
            }
            if (count == 3)
            {
                GW.Three();
            }
            if (count == 4)
            {
                GW.Four();
            }
        }
    }
}
