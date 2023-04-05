using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float sensitivity;

    public GameObject Camlook;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 Movementvector = new Vector3(x , rb.velocity.y, z);

        Movementvector = Movementvector.normalized;

        //rb.AddForce((Movementvector * speed * 100) * Time.deltaTime, ForceMode.Force);
        rb.AddForce((transform.forward * speed * z * 200) * Time.deltaTime);
        rb.AddForce((transform.right * speed * x * 200) * Time.deltaTime);


        float MouseX = Input.GetAxis("Mouse X") * sensitivity;
        float MouseY = Input.GetAxis("Mouse Y") * sensitivity;

        MouseY = Mathf.Clamp(MouseY, -90, 90);

        transform.Rotate(0, MouseX, 0);
        Camlook.transform.Rotate(-MouseY, 0, 0);
    }
}
