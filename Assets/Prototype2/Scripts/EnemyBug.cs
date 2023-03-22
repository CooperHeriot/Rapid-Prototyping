using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBug : MonoBehaviour
{
    public NavMeshAgent Navi;
    public float health;
    private float speed;
    public float WanderRange = 5;

    public GameObject Target, empty;

    public GameObject attack;

    public enum mood {wanderin, killin};

    public Vector3 newPos;
    public float patience, dist;

    public mood bugState;

    private bool togle;
    // Start is called before the first frame update
    void Start()
    {
       
        Navi = GetComponent<NavMeshAgent>();
        speed = Navi.speed;

        newPos = new Vector3(Random.Range(transform.position.x - WanderRange, transform.position.x + WanderRange), transform.position.y, Random.Range(transform.position.x - WanderRange, transform.position.x + WanderRange));

        bugState = mood.wanderin;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target.transform.position);
        /*if (Target != empty)
        {
            Navi.SetDestination(Target.transform.position);
        } else
        {
            bugState = mood.wanderin;
        }*/

        if (Vector3.Distance(transform.position, Target.transform.position) <= 5)
        {
            Navi.speed = 0;
            attack.SetActive(true);
        } else
        {
            Navi.speed = speed;
            attack.SetActive(false);
        }

        dist = Vector3.Distance(transform.position, newPos);
        if (togle == true)
        {
            Go();
            print("ges");
            togle = false;
        }

        if (bugState == mood.wanderin)
        {
            if (dist <= patience)
            {               
                patience = 0;
                newPos = new Vector3(Random.Range(transform.position.x - WanderRange, transform.position.x + WanderRange), transform.position.y, Random.Range(transform.position.x - WanderRange, transform.position.x + WanderRange));
                togle = true;                
            } else
            {
                patience += 0.2f * Time.deltaTime;
            }            
        } else
        {
            Navi.SetDestination(Target.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Termite")
        {
            Target = other.gameObject;

            bugState = mood.killin;
        }
    }

    public void SetEmpty()
    {
        Target = empty;
        bugState = mood.wanderin;
    }

    public void Go()
    {
        Target.transform.position = newPos;
        Navi.SetDestination(Target.transform.position);
    }
}
