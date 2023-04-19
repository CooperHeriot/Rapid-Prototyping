using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float ads, sbs, mls, dvs, total;
    public GameObject AL, SL, ML, DL, lights;
    // Start is called before the first frame update
    void Start()
    {
        lights.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ads <= 0)
        {
            AL.SetActive(false);
        } else
        {
            AL.SetActive(true);
        }
        if (sbs <= 0)
        {
            SL.SetActive(false);
        } else
        {
            SL.SetActive(true);
        }
        if (mls <= 0)
        {
            ML.SetActive(false);
        } else
        {
            ML.SetActive(true);
        }
        if (dvs <= 0)
        {
            DL.SetActive(false);
        } else
        {
            DL.SetActive(true);
        }

        total = (ads + sbs + mls + dvs);

        if (total <= 0)
        {
            lights.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
