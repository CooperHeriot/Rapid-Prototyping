using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    public float Total;

    public bool stopp = false;

    public TextMeshProUGUI tezt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stopp == false)
        {
            Total += 1 * Time.deltaTime;
            tezt.text = ("Time: " + Total);
        }
    }

    public void stopTime()
    {
        stopp = true;
    }
}
