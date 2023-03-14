using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionRing : MonoBehaviour
{
    public float scalee = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(scalee, transform.localScale.y, scalee);
    }

    public void ChangeSize(float newSize)
    {
        scalee = newSize;
    }
}
