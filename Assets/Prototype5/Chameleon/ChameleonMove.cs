using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChameleonMove : MonoBehaviour
{
    public float speed, MSpeed = 14, ASpeed = 5, jump = 2;

    public Rigidbody rb;

    public GameObject MainBod;
    public float BodTurnSpeed;
    public Vector3 modelDirection;

    private Quaternion slopeRotation;

    public float distToFloor;

    public bool grounded;
    public float howHighDoIHover;
    public float BodoffGround;
    public float stickiness;

    public float turnSens;


    private Vector3 LookCarry;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        modelDirection = transform.forward;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //MOVEMENT

        //float xMove = Input.GetAxis("Horizontal");
        //float zMove = Input.GetAxis("Vertical");

        //rb.velocity = new Vector3(xMove * speed, rb.velocity.y, zMove * speed);

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.rotation = new Quaternion(transform.rotation.x, Camera.main.transform.rotation.x, transform.rotation.z, transform.rotation.w);
        //}

        Vector3 fdInput = transform.forward * Input.GetAxis("Vertical");
        Vector3 sdInput = transform.right * Input.GetAxis("Horizontal");
        //Vector3 upInput = Vector3.up * rb.velocity.y;
        //Vector3 moveMentVector = fdInput + sdInput;
        //if (moveMentVector.magnitude > 1)
        // {
        //    moveMentVector.Normalize();
        //}
        //IMPORTANT
        //rb.velocity = moveMentVector * speed + transform.up * rb.velocity.y;

        //wonky code
        // experiment = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

        // rb.MovePosition(rb.position + transform.TransformDirection(experiment));
        rb.AddForce(fdInput * speed);
        rb.AddForce(sdInput * speed);

        Vector3 lookDirection = fdInput + sdInput;
        LookCarry = lookDirection;

        if (lookDirection.magnitude > 0.1f)
        {
            modelDirection = Vector3.Slerp(modelDirection, lookDirection, BodTurnSpeed * Time.deltaTime);
            MainBod.transform.rotation = Quaternion.LookRotation(modelDirection);
        } /*else
        {
            MainBod.transform.Rotate(0, -Input.GetAxis("Mouse X") * (turnSens * 4) * Time.deltaTime, 0);
        }*/

        //transform.Rotate(0, Input.GetAxis("Mouse X") * (turnSens * 4) * Time.deltaTime, 0);

        //ROTATE WITH FLOOR

        transform.rotation = Quaternion.Slerp(transform.rotation, slopeRotation * transform.rotation, 10 * Time.deltaTime);

        // if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        // {
        //     
        // } else
        // {
        //     transform.rotation = Quaternion.Slerp(transform.rotation, slopeRotation * transform.rotation, 10 * Time.deltaTime);
        //}
        //floating


        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up * -1, out hit, distToFloor))
        {
            grounded = true;

            //rottrans = Quaternion.LookRotation(hit.normal);

            //transform.rotation = new Quaternion((rottrans.x), transform.rotation.y, transform.rotation.z, transform.rotation.w);
            //MainBod.transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;


            //stupid cursed code below
            // transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
            slopeRotation = Quaternion.FromToRotation(transform.up, hit.normal);

        } else
        {
            grounded = false;            
        }

        //HOVER OFF OF GROUND

        BodoffGround = (Vector3.Distance(transform.position, hit.point));

        if (grounded == true)
        {
            //rb.AddForce(0, (0.9f - BodoffGround), 0);

            rb.useGravity = false;
            rb.drag = 3f;
            speed = MSpeed;

            rb.AddRelativeForce(0, (howHighDoIHover - BodoffGround), 0);

            if (BodoffGround > howHighDoIHover)
            {
                rb.AddRelativeForce(0, -stickiness, 0);
            }

            //SILLY LITTLE JUMP TEST

            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddRelativeForce(0, jump, 0, ForceMode.VelocityChange);
            }*/
        } else
        {
            rb.useGravity = true;
            rb.drag = 0.2f;
            speed = ASpeed;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, distToFloor))
            {
                grounded = true;
                slopeRotation = Quaternion.FromToRotation(transform.up, hit.normal);

            }

            //slopeRotation = startRot;
        }
       
    }

    private void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * (turnSens * 4) * Time.deltaTime, 0);

        if (LookCarry.magnitude <= 0.1f)
        {
            MainBod.transform.Rotate(0, -Input.GetAxis("Mouse X") * (turnSens * 4) * Time.deltaTime, 0);
        }


        if (Input.GetKey(KeyCode.Space) && grounded == true)
        {
            rb.AddRelativeForce(0, ((jump * 30) * Time.deltaTime), 0, ForceMode.VelocityChange);
        }
    }
}
