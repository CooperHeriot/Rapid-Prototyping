using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{

    public float x, y, z;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(x, y, z);
    }
}
