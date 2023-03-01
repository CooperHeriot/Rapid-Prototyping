using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : GameBehaviour<UIManager>
{
    public TMP_Text scoreText, timerText;
    int score, scoreBonus = 50;
    public Ease ScoreEase;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    void Update()
    {
        timerText.text = _T.GetTime().ToString();
    }

    // Update is called once per frame
    public void TweenScore()
    {
        DOTween.To(() => score, x => score = x, score + scoreBonus, 1).SetEase(ScoreEase).OnUpdate(() =>
        {
            scoreText.text = "Score: " + score.ToString();
        });
    }
}
