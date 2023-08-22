using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingScore : MonoBehaviour
{
    private int rankingNum = 5;
    private float[] ranking;

    public Text[] rankingScoreText;

    // �����L���O�X�R�A�̕\�����鏈��
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
            rankingScoreText[i].text = (i + 1) + " �� " + ranking[i].ToString("0000000");

            // ���ꂼ��̃����L���O�X�R�A�̒l��ݒ�
            PlayerPrefs.SetFloat("HIGHSCORE"+ (i + 1), ranking[i]);
        }

        // �ύX�����l��ۑ�
        PlayerPrefs.Save();
    }
}
