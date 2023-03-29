using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildController : MonoBehaviour
{
    public float winAmount, currentaAmount;
    public GameObject newThing, particles;
    private bool once = false;
    // Start is called before the first frame update
    void Start()
    {
        newThing.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentaAmount == winAmount && once == false)
        {
            Instantiate(particles);
            newThing.SetActive(true);
            once = true;

            //transform.position = Vector3.Lerp(transform.position, new Vector3(100, 0, 0), 3 * Time.deltaTime);
        }
    }
}
