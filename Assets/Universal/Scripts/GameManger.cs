using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : GameBehaviour<GameManger>
{
    // Start is called before the first frame update
    void Start()
    {
        //_T.ChangeDirection();
        _T.StartTimer(0, TimeDirection.CountUp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            _T.ChangeDirection(TimeDirection.CountDown);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            _T.ChangeDirection(TimeDirection.CountUp);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (_T.isTiming)
            {
                _T.PauseTimer();
            } else
            {
                _T.ResumeTimer();
            }
        }


        if (_T.TimeOut())
        {
            print("bruh");
        }
    }
}
