using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantAttack : MonoBehaviour
{
    [Header("Attack Prefabs")]

    public GameObject laser;
    public GameObject missile;
    public GameObject fist;

    [Header("Attack Spawnpoints")]

    public GameObject lPoint;
    public GameObject MPoint;

    [Header("Current Attack")]

    public GameObject current;

    [Header("The Player")]

    public GameObject playa;

    [Header("Floats")]

    public float timer;
    public float choice;
    private float timerr;
    // Start is called before the first frame update
    void Start()
    {
        playa = GameObject.Find("Player");

        timerr = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0)
        {
            timer = timerr;

            choice = Random.Range(1, 4);

            if (choice == 1)
            {
                current = laser;

                Instantiate(laser, lPoint.transform.position, lPoint.transform.rotation);
            }

            if (choice == 2)
            {
                current = missile;

                Instantiate(missile, missile.transform.position, missile.transform.rotation);
            }

            if (choice == 3)
            {
                current = laser;

                Instantiate(laser, lPoint.transform.position, lPoint.transform.rotation);
            }
        }
    }
}
