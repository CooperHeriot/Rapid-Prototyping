using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KILL : GameBehaviour
{
    public PlayerControler Playe;
    // Start is called before the first frame update
    void Start()
    {
        Playe = _PC;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            _PC.enabled = false;
        }

        if (other.transform.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }
}
