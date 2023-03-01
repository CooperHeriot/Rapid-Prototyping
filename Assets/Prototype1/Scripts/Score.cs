using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : GameBehaviour<Score>
{
    public float score, killCount;

    public TextMeshProUGUI sc;

    public bool halt = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (halt == false)
        {
            score += 1 * Time.deltaTime;


        } else
        {
            Tally();
        }
        
    }

    public void EnemyDead()
    {
        if (halt == false)
        {
            killCount += 1;
        }
        //killCount += 1;
    }

    public void Tally()
    {
        sc.text = ("You survived " + score + " seconds, and knocked out " + killCount + " enemies");
    }
}
