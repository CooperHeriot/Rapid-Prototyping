using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float currentHealth = 5;

    private float maxHP;

    public bool dead;
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
            dead = true;
        }
    }

    public void Hurt()
    {
        currentHealth -= 1;
    }
}
