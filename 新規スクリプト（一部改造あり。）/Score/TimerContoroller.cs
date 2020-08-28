using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TimerContoroller : MonoBehaviour
{
   
    public Health health;

    public Text timerText;
    
    public float totalTime = 0.0f;

    //タイムリミット
    public float timeLimit = 5.0f;


    public int scoreb;

    public static int scorea;

    int seconds;


    
    





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health != false)
        {
            totalTime += Time.deltaTime;

        }
        else
        {
            return;
        }

        seconds = (int)totalTime;

        timerText.text = seconds.ToString();

        scoreb = seconds;

        scorea = seconds;

        string GX = health.score + "";

        

    }
}
