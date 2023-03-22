using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TermiteCounter : MonoBehaviour
{
    public int popukation;
    public TextMeshProUGUI textt;

    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        popukation = FindObjectsOfType<Termite>().Length;

        textt.text = ("Termite Count: " + popukation);

        if (popukation <= 0)
        {
            gameOver.SetActive(true);
        }
    }
}
