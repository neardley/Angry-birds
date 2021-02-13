using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class score_counter : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
        changeTxt();
    }

    public void changeTxt()
    {
        string scoreShow = ScoreTracker.ScoreToScreen();
        int Scoredata = ScoreTracker.ScoretoData();
        if (ScoreTracker.WhatLvl() < 2)
        {
            if (Scoredata > 0)
            {
                scoreText.text = ("You have " + scoreShow + " shots left");
            }
            else
            {
                scoreText.text = ("You have run out of shots... Game Over");
            }
        } else
        {
            scoreText.text = ("You have made it through with " + scoreShow + " shots remaining.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
