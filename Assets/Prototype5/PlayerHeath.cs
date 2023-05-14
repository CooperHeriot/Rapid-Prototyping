using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeath : MonoBehaviour
{
    public Image PB;
    public PlayerHealth PH;
    //public PlayerHealth PH;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PB.fillAmount = PH.currentHealth / PH.maxHp;

        ///PB.fillAmount = PH.currentHealth / PH.maxHp;
    }
}
