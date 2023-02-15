using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTime : GameBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        ScaleToZero(player);

        ExecuteAfterSeconds(2,() => ScaleToZero(player));

        ExecuteAfterFrames(2,() => 
        {
            ScaleToZero(player);
            print("bruh");
        });
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            ChangePlayerCoulor();
        }
    }

    void ChangePlayerCoulor()
    {
        player.GetComponent<Renderer>().material.color = GetRandomColor();
    }
}
