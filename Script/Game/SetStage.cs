using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetStage : MonoBehaviour
{
    private int stageNum;

    public Text stageText;
    public GameObject[] stage;

    void Update()
    {
        stageNum = PlayerPrefs.GetInt("STAGE", 0);
        stageText.text = "ステージ:" + stageNum.ToString("00");
            
        // 数字ごとにステージを表示する
        switch (stageNum)
        {
            case 1:
                stage[0].SetActive(true);
                break;
            case 2:
                stage[1].SetActive(true);
                break;
            case 3:
                stage[2].SetActive(true);
                break;
            case 4:
                stage[3].SetActive(true);
                break;
            case 5:
                stage[4].SetActive(true);
                break;
            case 6:
                stage[5].SetActive(true);
                break;
            case 7:
                stage[6].SetActive(true);
                break;
            case 8:
                stage[7].SetActive(true);
                break;
            case 9:
                stage[8].SetActive(true);
                break;
            case 10:
                stage[9].SetActive(true);
                break;
        }
    }
}
