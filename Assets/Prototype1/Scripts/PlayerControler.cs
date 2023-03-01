using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : GameBehaviour<PlayerControler>
{
    private Rigidbody playerRb;
    public float speed = 5.0f;

    private GameObject focalPoint;

    public bool hasPowerup;
    public float powerupStrength = 15.0f;

    public GameObject powerupIndicator;

    public bool goodControls;
    private RotateCamera RC;

    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = FindObjectOfType<RotateCamera>().gameObject;

        gameOver = FindObjectOfType<Menu>().gameObject;

        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        if (goodControls == false)
        {
            playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
            focalPoint.GetComponent<RotateCamera>().enabled = true;
        } else
        {
            playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
            playerRb.AddForce(focalPoint.transform.right * speed * horizontalInput);
            focalPoint.GetComponent<RotateCamera>().enabled = false;
        }
        

        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);

        if (speed == 0)
        {
            _SC.halt = true;
            gameOver.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(14);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyBody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);

            if (hasPowerup == true)
            {
                Debug.Log("Collided wit" + collision.gameObject.name + " with powerup set to " + hasPowerup);
                enemyBody.AddForce((awayFromPlayer * powerupStrength) * Time.deltaTime, ForceMode.Impulse);
            }
            enemyBody.AddForce((awayFromPlayer * 35) * Time.deltaTime, ForceMode.Impulse);
        }
    }

    public void ToggleControls()
    {
        goodControls = !goodControls;
    }
}
