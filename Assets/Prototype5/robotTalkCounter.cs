using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class robotTalkCounter : MonoBehaviour
{
    public float maxRob, currentRob;

    public TextMeshProUGUI tes;

    public GameObject God;
    // Start is called before the first frame update
    void Start()
    {
        God.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        tes.text = (currentRob + "/" + maxRob);

        if (currentRob == maxRob)
        {
            God.SetActive(true);
        }
    }
}
