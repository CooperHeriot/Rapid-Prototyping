using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : GameBehaviour
{
    public int score;
    public int highScore;
    public string playtime;
    GameDataManager _Data;

    // Start is called before the first frame update
    void Start()
    {
        _Data = GameDataManager.INSTANCE;

        score = _Data.GetScore();
        highScore = _Data.GetHighestScore();
        playtime = _Data.GetTimeFormatted();

        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Save();
        }
    }

    void Save()
    {
        _Data.SetScore(score);

       // _Data.SetTimePlayed();

        _Data.SaveData();
    }
}
