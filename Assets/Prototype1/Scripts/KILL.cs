using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KILL : GameBehaviour
{
    public PlayerControler Playe;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        Playe = _PC;

        //gameOver = GameObject.Find("Gameovered");

        /*gameOver = FindObjectOfType<Menu>().gameObject;

        gameOver.SetActive(false);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            // _PC.enabled = false;/
            //SceneManager.LoadScene("Prototype 1Title");
            _PC.speed = 0;

            _PC.gameObject.GetComponent<SphereCollider>().enabled = false;
            _PC.gameObject.GetComponent<Rigidbody>().isKinematic = true;

            //gameOver.SetActive(true);
        }

        if (other.transform.tag == "Enemy")
        {
            _SC.EnemyDead();

            Destroy(other.gameObject);
        }
    }
}
