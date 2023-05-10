using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float currentHealth = 5;

    private float maxHP;

    public bool dead;

    public GameObject onDeath;


    // Start is called before the first frame update
    void Start()
    {
        maxHP = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            //dead = true;
            Instantiate(onDeath, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }

    public void Hurt()
    {
        currentHealth -= 1;
    }
}
