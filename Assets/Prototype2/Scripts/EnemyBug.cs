using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBug : MonoBehaviour
{
    public NavMeshAgent Navi;
    public float health;

    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        Navi = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Target != null)
        {
            Navi.SetDestination(Target.transform.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Termite")
        {
            Target = other.gameObject;
        }
    }
}
