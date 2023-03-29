using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuildController : MonoBehaviour
{
    public float winAmount, currentaAmount;
    public GameObject newThing, particles, splashText;
    private bool once = false;
    public string Splashtext = "If Youre reading this i forgot to set the text";

    public bool started = true;
    // Start is called before the first frame update
    void Start()
    {
        newThing.SetActive(false);
        splashText.GetComponent<TextMeshProUGUI>().text = Splashtext;
    }

    // Update is called once per frame
    void Update()
    {
        if (started == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(0, transform.position.y, transform.position.z), 0.2f * Time.deltaTime);

            if (Vector3.Distance(transform.position, new Vector3(0, transform.position.y, transform.position.z)) < 1)
            {
                started = false;
            }
        }

        if (currentaAmount == winAmount)
        {
            started = false;
            if (once == false)
            {
                Instantiate(particles);
                newThing.SetActive(true);
                once = true;

                GameObject.Find("Player").GetComponent<ballArm>().resetArms();
            }
            transform.position = Vector3.Lerp(transform.position, new Vector3(-900, transform.position.y, transform.position.z), 0.2f * Time.deltaTime);

            if (Vector3.Distance(transform.position, new Vector3(-900, transform.position.y, transform.position.z)) < 100)
            {
                Destroy(gameObject);
            }
        }
    }
}
