using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class giantWalk : MonoBehaviour
{
    public GameObject point1, point2, point3, point4;

    public GameObject CurrentDest;

    public bool Movin, engaged;

    public bool p1, p2, p3, p4, once;

    public float speed, dist;

    private float sped, timer;

    private NavMeshAgent Nav;

    public GameObject playa;

    private bool PB = false;
    // Start is called before the first frame update
    void Start()
    {
        Nav = GetComponent<NavMeshAgent>();

        sped = Nav.speed;

        ChangeDest(point1);

        timer = 3;

        playa = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //dist = Nav.remainingDistance;
        dist = Vector3.Distance(transform.position, CurrentDest.transform.position);

        /*if (dist == 0 && CurrentDest == point1 && engaged == false)
        {
            ChangeDest(point2);
            print("1");
        }

        if (dist == 0 && CurrentDest == point2 && engaged == false)
        {
            ChangeDest(point3);
            print("2");
        }

        if (dist == 0 && CurrentDest == point3 && engaged == false)
        {
            ChangeDest(point4);
            print("3");
        }

        if (dist == 0 && CurrentDest == point4 && engaged == false)
        {
            ChangeDest(point1);
            print("4");
        }*/
        /*if (once == false)
        {
            if (dist <= 10 && p1 == true && engaged == false)
            {
                ChangeDest(point2);
                print("1");
                turnOff(2);

                once = true;
            }

            if (dist <= 10 && p2 == true && engaged == false)
            {
                ChangeDest(point3);
                print("2");
                turnOff(3);

                once = true;
            }

            if (dist <= 10 && p3 == true && engaged == false)
            {
                ChangeDest(point4);
                print("3");
                turnOff(4);

                once = true;
            }

            if (dist <= 10 && p4 == true && engaged == false)
            {
                ChangeDest(point1);
                print("4");
                turnOff(1);

                once = true;
            }
        } else
        {
            timer -= 1 * Time.deltaTime;
        }*/
        
        if (timer <= 0)
        {
            once = false;
            timer = 3;
        }



        if (Movin == true)
        {
            Nav.speed = sped;
        } else
        {
            Nav.speed = 0;
        }


       /* if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeDest(point1);
            turnOff(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeDest(point2);
            turnOff(2);

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeDest(point3);
            turnOff(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ChangeDest(point4);
            turnOff(4);
        }*/

        /* if (CurrentDest == point1)
        {
            print("fsdfsdfdsfds");
        }*/

        if (engaged == true && PB == false)
        {
            ChangeDest(playa);

            //PB = true;
        }
    }

    public void One()
    {
        if (engaged == false)
        {
            ChangeDest(point1);
            turnOff(1);
        }
    }
    public void Two()
    {
        if (engaged == false)
        {
            ChangeDest(point2);
            turnOff(2);
        }
    }
    public void Three()
    {
        if (engaged == false)
        {
            ChangeDest(point3);
            turnOff(3);
        }
    }
    public void Four()
    {
        if (engaged == false)
        {
            ChangeDest(point4);
            turnOff(4);
        }
        
    }

    public void ChangeDest(GameObject NewDest)
    {        
        print("sfds");

        CurrentDest = NewDest;

        Nav.SetDestination(CurrentDest.transform.position);

        /* if (CurrentDest == point1)
        {
            print("fsdfsdfdsfds");
        }*/
        

    }

    public void turnOff(float num)
    {
        if (engaged == false)
        {
            if (num == 1)
            {
                p1 = true;
                p2 = false;
                p3 = false;
                p4 = false;

                print("323");
            }

            if (num == 2)
            {
                p1 = false;
                p2 = true;
                p3 = false;
                p4 = false;

                print("435436");
            }

            if (num == 3)
            {
                p1 = false;
                p2 = false;
                p3 = true;
                p4 = false;

                print("5867");
            }

            if (num == 4)
            {
                p1 = false;
                p2 = false;
                p3 = false;
                p4 = true;

                print("098");
            }
        }
        
    }
}
