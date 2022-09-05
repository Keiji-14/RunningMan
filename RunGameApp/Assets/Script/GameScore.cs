using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    private float highScore;

    [Header("ScoreText")]
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    
    private GameObject playerObject;
    protected static float score = 0;
    
    Player player;

    // エンドレスモードのスコアとハイスコアを表示する処理
    void Update()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        player = playerObject.GetComponent<Player>();
        score = player.scoreNum;

        // ハイスコアはランキング1位のスコアを表示
        highScore = PlayerPrefs.GetFloat("HIGHSCORE1", 0);
        scoreText.text = "スコア:" + score.ToString("0000000");
        highScoreText.text = "ハイスコア:" + highScore.ToString("0000000");
    }
    public static float GetScore()
    {
        return score;
    }
}
