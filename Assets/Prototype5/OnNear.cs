using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnNear : MonoBehaviour
{
    public GameObject ThingToTurnOn;

    private GameObject Player;

    public float dist, radius = 10;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, Player.transform.position);

        if (dist <= radius)
        {
            ThingToTurnOn.SetActive(true);
        } else
        {
            ThingToTurnOn.SetActive(false);
        }
    }
}
