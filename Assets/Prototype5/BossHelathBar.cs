using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHelathBar : MonoBehaviour
{
    public Image HB;
    public EnemyHealth EH;
    //public PlayerHealth PH;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HB.fillAmount = EH.currentHealth / 100;

        ///PB.fillAmount = PH.currentHealth / PH.maxHp;
    }
}
