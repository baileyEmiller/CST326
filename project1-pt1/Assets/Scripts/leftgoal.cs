using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftgoal : MonoBehaviour
{
    public Transform ballPos;
    private Vector3 ballStartPos;
    private int player1score = 0;

    private void Start()
    {
        ballStartPos = new Vector3(0, 0.5f, 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        player1score++;
        Debug.Log("Player one scored! Their score is now " + player1score);
        newBall();

    }

    void newBall()
    {
        ballPos.position = ballStartPos;
    }
}
