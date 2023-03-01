using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : GameBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;

    public bool notSpace;

    public Score sca;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

        sca = _SC;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);     


        if (transform.position.y < -10 && notSpace == true)
        {
            //sca.EnemyDead();

            Destroy(gameObject);
        }

        
    }
}
