using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controls : MonoBehaviour
{
    public PlayerControler PC;
    public TextMeshProUGUI tekts;
    // Start is called before the first frame update
    void Start()
    {
        ////tekts = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PC.goodControls == true)
        {
            tekts.text = ("Strafe");
        } else
        {
            tekts.text = ("Rotate");
        }
    }
}
