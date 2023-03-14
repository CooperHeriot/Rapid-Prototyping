using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionRing : MonoBehaviour
{
    public float scalee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(scalee, scalee, scalee);
    }
}
