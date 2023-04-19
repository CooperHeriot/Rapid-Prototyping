using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSaving : MonoBehaviour
{
    int score = 0;
    int highScore = 0;

    // Update is called once per frame
    void Start()
    {
        print ("Score: " + score);

        highScore = PlayerPrefs.GetInt("HighScore");

        print ("High Score: " + highScore);

        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 1;
            print("Score: " + score);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        print("Game Over");

        if (score > highScore)
        {
            highScore = score;
            print("New Highscore" + highScore);
            PlayerPrefs.SetInt("HighScore", score);
        }
        //PlayerPrefs.SetInt("HighScore", score);
    }
}
