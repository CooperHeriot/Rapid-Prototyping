using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Android;


public class PlayTime : GameBehaviour
{
  /*  public enum Direction
    {
        up, down, left, right
    }


   // public Direction direct;

    public GameObject player;
    public float tweenTime = 2;
    public float moveDistance = 5;

    public Ease moveEase;
    public Ease scaleEase;
    // Start is called before the first frame update
    void Start()
    {
        /*
        ScaleToZero(player);

        ExecuteAfterSeconds(2,() => ScaleToZero(player));

        ExecuteAfterFrames(2,() => 
        {
            ScaleToZero(player);
            print("bruh");
        });*//*
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            ChangePlayerCoulor();
        }

        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Direction.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Direction.left);
        }
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Direction.up);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Direction.down);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ScalePlayer(Vector3.one);
        }
    }

    void MovePlayer(Direction _direc)
    {
        //player.transform.DOMoveX(player.transform.position.x + moveDistance, tweenTime);

        switch (_direc)
        {
            case Direction.left:
                player.transform.DOMoveX(player.transform.position.x - moveDistance, tweenTime).SetEase(moveEase).OnComplete(()=> ShakeCamera());
                break;
            case Direction.right:
                player.transform.DOMoveX(player.transform.position.x + moveDistance, tweenTime).SetEase(moveEase).OnComplete(() => ShakeCamera());
                break;
            case Direction.up:
                player.transform.DOMoveZ(player.transform.position.z + moveDistance, tweenTime).SetEase(moveEase).OnComplete(() => ShakeCamera());
                break;
            case Direction.down:
                player.transform.DOMoveZ(player.transform.position.z - moveDistance, tweenTime).SetEase(moveEase).OnComplete(() => ShakeCamera());
                break;
        }
        ScalePlayer(player.transform.localScale);
    }

    void ScalePlayer(Vector3 _scaleTo)
    {
        player.transform.DOScale(_scaleTo, tweenTime).SetEase(moveEase);
    }

    void ChangePlayerCoulor()
    {
        //player.GetComponent<Renderer>().material.color = GetRandomColor();
        player.GetComponent<Renderer>().material.DOColor(GetRandomColor(), 0.5f);
    }

    void ShakeCamera()
    {
        Camera.main.DOShakePosition(tweenTime / 2, 0.4f);
        _UI.TweenScore();
    }*/
}
