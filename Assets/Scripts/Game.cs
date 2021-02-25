﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnBall()
    {
        ball = GameObject.Instantiate ((GameObject)Resources.Load("prefabs/ball", typeof(GameObject)));
        ball.transform.localPosition = new Vector3(7.6f,0,0);
    }
}
