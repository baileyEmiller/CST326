using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightgoal : MonoBehaviour
{
    public Transform ballPos;
    private Vector3 ballStartPos;
    private int player2score = 0;

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
        player2score++;
        Debug.Log("Player two scored! Their score is now " + player2score);
        newBall();

    }

    void newBall()
    {
        ballPos.position = ballStartPos;
    }
}
