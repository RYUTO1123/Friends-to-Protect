using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simage : MonoBehaviour
{
    public CanvasRenderer[] TimerContoroller ;
    public TimerContoroller StBTNSc;
    int num;
    int oldNum;

    public int keta;

    void Start()
    {
        numOn();
    }

    void Update()
    {
        string scoreStrings = StBTNSc.scoreb + "";
        Debug.Log(keta+" : "+ StBTNSc.scoreb);
        if (scoreStrings.Length >= keta)
        {
            num = int.Parse(SubstringRight(scoreStrings, keta));
            Debug.Log(keta+" : " + num);
            if (oldNum != num) numOn();
        }
    }

    string SubstringRight(string tarNum, int length)
    {
        const int mojisu = 1;
        return tarNum.Substring(tarNum.Length - length, mojisu);
    }

    void numOn()
    {
        oldNum = num;
        allNumClear();
        TimerContoroller[num].SetAlpha(1.0f);
    }

    void allNumClear()
    {
        foreach (CanvasRenderer tmpCR in TimerContoroller)
        {
            tmpCR.SetAlpha(0.0f);
        }
    }




}