using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {
    private int Number; //的の数
    public int ShotScore; //命中ボーナス
    private float Time; //経過時間
    private int ShotNumber; //消費弾数
    private int TimeScore = 0; //時間ボーナス
    private int TargetPoint;
    private float ShotRate;
    private int Total;
    private int Hscore;

    public Text Target;
    public Text Times;
    public Text Shot;
    public Text Score;
    public Text Rank;

    // Use this for initialization
    void Start() {
        Number = PlayerPrefs.GetInt("Frg");

        //命中スコアの計算
        TargetPoint = Number * 1000;
        Target.text = "Target Score : "+ Number + "* 1000 = +" + TargetPoint;

        //時間ボーナスの計算
        Time = PlayerPrefs.GetFloat("Tim");
        if ((int)Time < 300) //5分以内なら時間ボーナス加算
        {
            TimeScore = (300 - (int)Time) * 10;
            Times.text = "Time Bonus   : "+ (int)Time + "        +" + TimeScore; 
        }
        else
        {
            TimeScore = 0;
            Times.text = "Time Bonus : " + "Over 5 min " + " +" + TimeScore;
        }


        //命中ボーナスの計算
        ShotNumber = PlayerPrefs.GetInt("Hit");
        ShotRate = (float)Number / (float)ShotNumber *100;
        ShotScore = (int)ShotRate * 20;
        Shot.text = "Shot Bonus   : " + (int)ShotRate + " %" + "      +" + ShotScore;

        //合計スコア
        Total = TargetPoint + ShotScore + TimeScore;

        //ベスト更新処理
        Hscore = PlayerPrefs.GetInt("high");
        if (Total > Hscore)
        {
            PlayerPrefs.SetInt("high", Total);
            Score.text = "Total Score  : " + Total + " New Record!";
        }
        else
        {
            Score.text = "Total Score  : " + Total;
        }

        //ランク表示
        if(Total > 14000)
        {
            Rank.text = "Your Rank  : SSS";
        }
        else if(Total > 13500)
        {
            Rank.text = "Your Rank  : SS";
        }
        else if(Total > 13000)
        {
            Rank.text = "Your Rank  : S";
        }
        else if(Total > 12500)
        {
            Rank.text = "Your Rank  : A";
        }
        else if (Total > 12000)
        {
            Rank.text = "Your Rank  : B";
        }
        else if (Total > 11500)
        {
            Rank.text = "Your Rank  : C";
        }
        else
        {
            Rank.text = "Your Rank  : AMEBA";
        }
        
        //暫定処理
        /*if (Total > 12000)
        {
            Rank.text = "Your Rank  : SSS";
        }
        else if (Total > 11500)
        {
            Rank.text = "Your Rank  : SS";
        }
        else if (Total > 11000)
        {
            Rank.text = "Your Rank  : S";
        }
        else if (Total > 10500)
        {
            Rank.text = "Your Rank  : A";
        }
        else if (Total > 10000)
        {
            Rank.text = "Your Rank  : B";
        }
        else if (Total > 9500)
        {
            Rank.text = "Your Rank  : C";
        }
        else
        {
            Rank.text = "Your Rank  : AMEBA";
        }*/
    }

//    private void Update()
//    {
        //if (Input.GetKey("K"))
        //{
        //    PlayerPrefs.SetInt(high, 0);
        //}
//    }
}
