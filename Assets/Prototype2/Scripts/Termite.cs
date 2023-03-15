using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Termite : MonoBehaviour
{
    public bool Selected;
    public NavMeshAgent nav;
    public GameObject selfectIcon;

    private float tim = 0.1f;
    private bool brug;
    //public V
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Selected == true)
        {
            selfectIcon.SetActive(true);
        } else
        {
            selfectIcon.SetActive(false);
        }

        if (Input.GetMouseButtonDown(1) && Selected == true)
        {
            brug = true;
            
            Selected = false;
        }

        if (brug == true)
        {
            tim -= 1 * Time.deltaTime;
        }

        if (tim <= 0)
        {
            nav.SetDestination(GameObject.Find("Goto").transform.position);
            tim = 0.1f;
            brug = false;
        }
    }
}
