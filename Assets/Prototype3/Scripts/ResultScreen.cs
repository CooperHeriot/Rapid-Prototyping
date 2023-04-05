using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScreen : MonoBehaviour
{
    public CountDown CD;

    public float Goal1, Goal2, Goal3, Goal4, Goal5;
    public Image ABad, AMeh, Aok, AGood, AGreat;

    public GameObject FinalR;

    public float TimeTaken;
    // Start is called before the first frame update
    void Start()
    {
        CD.stopp = true;
        TimeTaken = CD.Total;
    }

    // Update is called once per frame
    void Update()
    {
        if (CD.stopp == true)
        {
            if (TimeTaken >= Goal1)
            {
                FinalR.GetComponent<Image>().sprite = ABad.sprite;
            } else
            {
                if (TimeTaken >= Goal2)
                {
                    FinalR.GetComponent<Image>().sprite = AMeh.sprite;
                } else
                {
                    if (TimeTaken >= Goal3)
                    {
                        FinalR.GetComponent<Image>().sprite = Aok.sprite;
                    } else
                    {
                        if (TimeTaken >= Goal4)
                        {
                            FinalR.GetComponent<Image>().sprite = AGood.sprite;
                        } else
                        {
                            if (TimeTaken <= Goal5)
                            {
                                FinalR.GetComponent<Image>().sprite = AGreat.sprite;
                            }
                        }
                    }
                }
            }
        }
    }

    /*public void KillOther()
    {
        if (ABad.activeInHierarchy == false)
        {
            Destroy(ABad);
        }

        if (AMeh.activeInHierarchy == false)
        {
            Destroy(AMeh);
        }

        if (Aok.activeInHierarchy == false)
        {
            Destroy(Aok);
        }

        if (AGood.activeInHierarchy == false)
        {
            Destroy(AGood);
        }

        if (AGreat.activeInHierarchy == false)
        {
            Destroy(AGreat);
        }
    }*/
}
