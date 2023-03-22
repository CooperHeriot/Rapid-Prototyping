using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Spawner : GameBehaviour
{
    public GameObject termite, spawnpos;
    public GameObject kill, win;
    public float food;

    public TextMeshProUGUI test;
    // Start is called before the first frame update
    void Start()
    {
        win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(termite, transform.position, transform.rotation);
        }*/

        test.text = (food + "/100");

        if (food >= 100)
        {
            Destroy(kill.gameObject);

            win.SetActive(true);
        }
    }

    public void SpawnTermite()
    {
        if (food >= 1)
        {
            Instantiate(termite, spawnpos.transform.position, transform.rotation);
            food -= 1;
        }       
    }
}
