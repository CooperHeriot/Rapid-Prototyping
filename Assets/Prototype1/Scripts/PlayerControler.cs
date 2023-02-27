using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : GameBehaviour<PlayerControler>
{
    private Rigidbody playerRb;
    public float speed = 5.0f;

    private GameObject focalPoint;

    public bool hasPowerup;
    private float powerupStrength = 15.0f;

    public GameObject powerupIndicator;

    public bool goodControls;
    private RotateCamera RC;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = FindObjectOfType<RotateCamera>().gameObject;
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
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyBody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);


            Debug.Log("Collided wit" + collision.gameObject.name + " with powerup set to " + hasPowerup);
            enemyBody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }

    public void ToggleControls()
    {
        goodControls = !goodControls;
    }
}
