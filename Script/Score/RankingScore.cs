using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingScore : MonoBehaviour
{
    private int rankingNum = 5;
    private float[] ranking;

    public Text[] rankingScoreText;

    // ランキングスコアの表示する処理
    void Start()
    {  
        ranking = new float[rankingNum];

        for(int i = 0; i < rankingNum; i++)
        {
            ranking[i] = PlayerPrefs.GetFloat("HIGHSCORE" + (i + 1), 0);
        }
    }

    void Update()
    {
        for (int i = 0; i < rankingNum; i++)
        {
            rankingScoreText[i].text = (i + 1) + " 位 " + ranking[i].ToString("0000000");

            // それぞれのランキングスコアの値を設定
            PlayerPrefs.SetFloat("HIGHSCORE"+ (i + 1), ranking[i]);
        }

        // 変更した値を保存
        PlayerPrefs.Save();
    }
}
