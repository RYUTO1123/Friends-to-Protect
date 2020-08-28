using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bestScoreScript : MonoBehaviour
{

    public TimerContoroller StBTNSc;
    public Text BstScrTxt;
    public int[] BestScores;
    string bstScr;
    // Start is called before the first frame update
    void Start()
    {
        // BstScrTxt.text = "testtest";
        Sortscores();
        ShowBestScore();


    }

// Update is called once per frame
    void Update()
    {
        
    }

    void Sortscores() 
    {
        Debug.Log(TimerContoroller.scorea);

        Array.Sort(BestScores);
        if (BestScores[0] > TimerContoroller.scorea)
        {
            BestScores[0] = TimerContoroller.scorea;
        }
        Array.Sort(BestScores);
    }

    void ShowBestScore()
    {
        bstScr = "";

        
        foreach (int scores in BestScores)
        {
            bstScr = bstScr + scores + "\n";
        }
        BstScrTxt.text = bstScr;
       
    }

}
