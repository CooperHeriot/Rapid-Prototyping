using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ghostUltimatum : MonoBehaviour
{
    public TextMeshProUGUI TP;
    public GhostFinder Gf;
    //public GameObject INPbase;

    public GameObject THeGost;
    public EquationGenerator EG;

    public GameObject Question;

    public TMP_InputField INP;

    public FpsController Fp;

    //public GameObject Menu;

    public bool once = false;
    public bool happening = false;

    private Pause PP;
    // Start is called before the first frame update
    void Start()
    {
        //INP = INPbase.GetComponent<TMP_InputField>
        Question.SetActive(false);

        PP = GameObject.Find("PauseContainer").GetComponent<Pause>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 10)){ 
            if (hit.transform.tag == "ghost" && Gf.HoldP == true && once == false)
            {
                happening = true;

                THeGost = hit.transform.gameObject;

                EG = hit.transform.gameObject.GetComponent<EquationGenerator>();

                WhatAmI Wah = hit.transform.gameObject.GetComponent<WhatAmI>();

                Fp.noWalk = true;

                Question.SetActive(true);

                if (Wah.add == true)
                {
                    once = true;

                    EG.GenerateAddition();

                    TP.text = (EG.numberOne + " + " + EG.numberTwo + " = ?");
                }

                
            } else
            {
                //print("zaza");
            }

            if (INP.text == EG.correctAnswer.ToString() && happening == true)
            {
                THeGost.SetActive(false);
                THeGost = null;
                EG = null;
                Fp.noWalk = false;
                once = false;
                Question.SetActive(false);

                happening = false;
            }


            if (happening == true)
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
            }
        }

        /*if (INP.text == "zaza")
        {
            print("dsadsadsadasdsadsaffsdfdafd");
        }*/

    }

    public void MoveOn()
    {

    }
}
