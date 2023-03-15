using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject ring, clickPoint, currentPoint, goTo;
    private SelectionRing selRing;

    public Vector3 ringPos;

    public bool dragging;

    public Termite[] terms;

    //mouse stuff
    public Camera cam;
    public Vector3 screenPos, worldPosition;
    public float dist;
    //public LayerMask flor;
    // Start is called before the first frame update
    void Start()
    {
        selRing = ring.GetComponent<SelectionRing>();
    }

    // Update is called once per frame
    void Update()
    {
        screenPos = Input.mousePosition;
        screenPos.z = dist;

        worldPosition = cam.ScreenToWorldPoint(screenPos);
        //RaycastHit hit;

        currentPoint.transform.position = worldPosition;


        ringPos = ((clickPoint.transform.position + currentPoint.transform.position) / 2);

        if (Input.GetMouseButtonDown(0)){
            clickPoint.transform.position = worldPosition;       
        }

        if (Input.GetMouseButtonDown(1))
        {
            goTo.transform.position = worldPosition;
        }

        if (Input.GetMouseButton(0))
        {
            dragging = true;
        } else
        {
            dragging = false;
        }


        if (dragging == true)
        {
            ring.SetActive(true);
            ring.transform.position = ringPos;
            selRing.ChangeSize(Vector3.Distance(clickPoint.transform.position, currentPoint.transform.position));


        } else
        {
            ring.SetActive(false);
        }
    }
}
