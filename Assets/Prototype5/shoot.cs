using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet, firingPoint, GunModel;

    public bool haveGun = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (haveGun == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, firingPoint.transform.position, firingPoint.transform.rotation);
            }

            GunModel.SetActive(true);
        } else
        {
            GunModel.SetActive(false);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Gun")
        {
            haveGun = true;
        }
    }
}
