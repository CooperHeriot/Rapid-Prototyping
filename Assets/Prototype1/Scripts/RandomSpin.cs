using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpin : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 Rand;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularDrag = 0;

        Rand.x = Random.Range(-2, 2);
        Rand.y = Random.Range(-2, 2);
        Rand.z = Random.Range(-2, 2);

        rb.AddTorque(Rand * 0.1f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
