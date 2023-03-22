using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    public float health;
    public GameObject food;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Instantiate(food, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }

    public void hurt()
    {
        health -= 0.01f;
    }
}
