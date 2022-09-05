using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    private int rankingNum = 5;
    private float resultScore;
    private float[] ranking;
    public Text resultText;

    // エンドレスモードのゲームオーバー画面のリザルトスコア表示の処理
    void Start()
    {
        // エンドレスモードの獲得したスコアを取得
        resultScore = GameScore.GetScore();
        resultText.text = "スコア:" + resultScore.ToString("0");

        ranking = new float[rankingNum];

        for (int i = 0; i < rankingNum; i++)
        {
            ranking[i] = PlayerPrefs.GetFloat("HIGHSCORE" + (i + 1), 0);
        }

        // リザルトのスコアが5位のスコアを上回ったら
        if (ranking[4] < resultScore)
        {
            ranking[4] = resultScore;
        }

        for (int i = 0; i < ranking.Length; i++)
        {
            for (int j = i; j < ranking.Length; j++)
            {
                if (ranking[i] < ranking[j])
                {
                    float tmp = ranking[i];
                    ranking[i] = ranking[j];
                    ranking[j] = tmp;
                }
            }
        }
    }

    void Update()
    {
        // それぞれのランキングスコアの値を設定
        for (int i = 0; i < rankingNum; i++)
        {
            PlayerPrefs.SetFloat("HIGHSCORE" + (i + 1), ranking[i]);
            ranking[i] = PlayerPrefs.GetFloat("HIGHSCORE" + (i + 1), 0);
        }

        // 変更した値を保存
        PlayerPrefs.Save();
    }
}
