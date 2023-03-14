using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject ring, clickPoint, currentPoint;
    private SelectionRing selRing;

    public Vector3 ringPos;

    public bool dragging;
    // Start is called before the first frame update
    void Start()
    {
        selRing = ring.GetComponent<SelectionRing>();
    }

    // Update is called once per frame
    void Update()
    {
        ringPos = ((clickPoint.transform.position + currentPoint.transform.position) / 2);

        if (Input.GetMouseButton(0)){
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
