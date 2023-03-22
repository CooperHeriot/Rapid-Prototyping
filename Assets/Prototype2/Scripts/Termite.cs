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

    public GameObject nest;
    public bool hasThing;
    //public V
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nest = GameObject.Find("Mound");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasThing == false)
        {
            if (Selected == true)
            {
                selfectIcon.SetActive(true);
            }
            else
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
        } else
        {
            nav.SetDestination(nest.transform.position);
            Selected = false;
        }

        if (Vector3.Distance(transform.position,nest.transform.position) < 5)
        {
            if (hasThing == true)
            {
                nest.GetComponent<Spawner>().food += 5;
            }

            hasThing = false;  
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Food")
        {
            Destroy(other.gameObject);
            hasThing = true;
        }

       /* if (other.transform.tag == "Enemy")
        {
            other.GetComponent<EnemyBug>().health -= 1;
        }*/

        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Tree")
        {
            other.GetComponent<tree>().hurt();
        }
    }
}
