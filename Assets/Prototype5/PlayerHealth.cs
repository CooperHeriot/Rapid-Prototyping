using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth = 10;
    private float maxHp, CD;
    public float Countdown = 5;

    public ChameleonMove CM;

    public GameObject gameOver;

    public bool dead;
    // Start is called before the first frame update
    void Start()
    {
        maxHp = currentHealth;
        CD = Countdown;

        Countdown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHp);

        if (currentHealth < maxHp && Countdown != 0)
        {
            currentHealth += 1 * Time.deltaTime;
        }

        if (Countdown >= 0)
        {
            Countdown -= 1 * Time.deltaTime;
        }

        if (dead == true)
        {
            CM.enabled = false;
        }
    }

    public void hurt()
    {
        Countdown = CD;

        currentHealth -= 1;

        if (currentHealth <= 0)
        {
            dead = true;
        }
    }
}
