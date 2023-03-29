using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballArm : MonoBehaviour
{
    public GameObject HJ1, HJ2;

    public HingeJoint HJJ1, HJJ2;

    public JointSpring HS1, HS2;

    public float Spring1, Spring2;

    public GameObject basee;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        HJJ1 = HJ1.GetComponent<HingeJoint>();
        HJJ2 = HJ2.GetComponent<HingeJoint>();
        // HJ2 = GetComponent<HingeJoint>();

        HS1 = HJJ1.spring;
        HS2 = HJJ2.spring;
    }

    // Update is called once per frame
    void Update()
    {
        //set springs
        HS1.targetPosition = Spring1;
        HJJ1.spring = HS1;

        HS2.targetPosition = Spring2;
        HJJ2.spring = HS2;



        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        basee.transform.Rotate(0, (x * speed) * Time.deltaTime, 0);
       // basee.transform.rotation = new Quaternion(transform.rotation.x, Mathf.Clamp(basee.transform.rotation.y, -45, 45), transform.rotation.z, 0);

        if (Input.GetKey(KeyCode.W))
        {
            Spring1 += 100 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Spring1 -= 100 * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Spring2 += 100 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            Spring2 -= 100 * Time.deltaTime;
        }

        Spring1 = Mathf.Clamp(Spring1, -80, 80);
        Spring2 = Mathf.Clamp(Spring2, -70, 70);
    }
}
