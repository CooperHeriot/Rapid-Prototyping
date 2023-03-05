using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

//public enum TimeDirection { CountUp, CountDown }

public class Timer : GameBehaviour<Timer>
{
/*

    public TimeDirection Direction; 
    public float startTime = 0;
    public float currentTime;
    public bool isTiming = false;
    float timeLimit = 0;
    bool hasTimeLimit = false;



    // Update is called once per frame
    void Update()
    {
        if (!isTiming)
            return;

        currentTime = Direction == TimeDirection.CountUp ? currentTime += Time.deltaTime : currentTime -= Time.deltaTime;
    }

    public void PauseTimer()
    {
        isTiming = false;
    }

    public void StartTimer(float _startTime = 0,TimeDirection _direction = TimeDirection.CountUp)
    {
        Direction = _direction;
        startTime = _startTime;
        isTiming = true;
    }


    public void StartTimer(float _startTime = 0, float _timeLimit = 0, bool _hasTimeLimit = true, TimeDirection _direction = TimeDirection.CountUp)
    {
        Direction = _direction;
        hasTimeLimit = _hasTimeLimit;
        startTime = _startTime;
        timeLimit = _timeLimit;
        isTiming = true;
    }

    public void ResumeTimer()
    {
        isTiming = true;
    }

    public void StopTimer()
    {
        isTiming = false;
    }

    public void incrementTimer(float _amount)
    {
        currentTime += _amount;
    }

    public bool TimeOut()
    {
        //return currentTime < timeLimit;
        if (!hasTimeLimit)
            return false;
        return Direction == TimeDirection.CountUp ? currentTime > timeLimit : currentTime < timeLimit;
    }


    public float GetTime()
    {
        return currentTime;
    }

    public bool IsTiming()
    {
        return isTiming;
    }

    public void ChangeDirection(TimeDirection _direction)
    {
        Direction = _direction;
    }*/
}
