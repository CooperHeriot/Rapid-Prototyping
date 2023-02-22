using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SceneFader : MonoBehaviour
{
    public CanvasGroup CG;
    // Start is called before the first frame update
    void Start()
    {
        CG.alpha = 1;
        FadeCanvas(0);
    }
    void FadeCanvas(float fadeTo)
    {
        CG.DOFade(fadeTo, 2);
    }

}
