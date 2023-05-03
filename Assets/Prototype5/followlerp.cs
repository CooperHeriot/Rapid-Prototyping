using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followlerp : MonoBehaviour
{
    public GameObject target;

    public bool pos = true, rot = true;

    public float posAmount, rotAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pos == true)
        {
            transform.position = Vector3.Slerp(transform.position, target.transform.position, posAmount * Time.deltaTime);
        } else
        {
            transform.position = target.transform.position;
        }
        if (rot == true)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, target.transform.rotation, rotAmount * Time.deltaTime);
        } else
        {
            transform.rotation = target.transform.rotation;
        }
    }

    public void ChangePos(float newPos)
    {
        posAmount = newPos;
    }
    public void ChangeRot(float newRot)
    {
        rotAmount = newRot;
    }
}
