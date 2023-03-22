using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugAttack : MonoBehaviour
{
    public EnemyBug body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Termite")
        {
            Destroy(other.gameObject);
            body.Target = body.empty;
            body.bugState = EnemyBug.mood.wanderin;
        }
    }
}
