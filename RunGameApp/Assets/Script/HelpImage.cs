using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpImage : MonoBehaviour
{
    private int helpNum;
    private int gameImageNum;
    private int operateImageNum;
    private int stageImageNum;

    [Header("Game")]
    [SerializeField] Text gameCountText;
    [SerializeField] GameObject[] gameImage;

    [Header("Operate")]
    [SerializeField] Text operateCountText;
    [SerializeField] GameObject[] operateImage;
    [SerializeField] GameObject[] operateText_PC;
    [SerializeField] GameObject[] operateText_Android;

    [Header("Stage")]
    [SerializeField] Text stageCountText;
    [SerializeField] GameObject[] stageImage;


    private enum Help
    {
        Game,
        Operate,
        Stage = 3,
    }

    // Page1に1を代入
    private enum Page
    {
        Page1 = 1,
        Page2,
        Page3,
    }

    void Update()
    {
        helpNum = PlayerPrefs.GetInt("HELP", 0);

        gameCountText.text = gameImageNum.ToString("0") + " / 3";
        operateCountText.text = operateImageNum.ToString("0") + " / 3";
        stageCountText.text = stageImageNum.ToString("0") + " / 2";

        switch (helpNum)
        {
            case (int)Help.Game:
                GameHelp();
                break;
            case (int)Help.Operate:
                OperateHelp();
                break;
            case (int)Help.Stage:
                StageHelp();
                break;
        }
    }

    private void GameHelp()
    {
        gameImageNum = PlayerPrefs.GetInt("GAMEHELP", 0);

        if (gameImageNum > 3)
        {
            gameImageNum = 1;
        }
        if (gameImageNum < 1)
        {
            gameImageNum = 3;
        }
        switch (gameImageNum)
        {
            case (int)Page.Page1:
                gameImage[0].SetActive(true);
                gameImage[1].SetActive(false);
                gameImage[2].SetActive(false);
                break;
            case (int)Page.Page2:
                gameImage[0].SetActive(false);
                gameImage[1].SetActive(true);
                gameImage[2].SetActive(false);
                break;
            case (int)Page.Page3:
                gameImage[0].SetActive(false);
                gameImage[1].SetActive(false);
                gameImage[2].SetActive(true);
                break;
        }
    }

    private void OperateHelp()
    {
        operateImageNum = PlayerPrefs.GetInt("OPERATEHELP", 0);
        if (operateImageNum > 3)
        {
            operateImageNum = 1;
        }
        if (operateImageNum < 1)
        {
            operateImageNum = 3;
        }
        switch (operateImageNum)
        {
#if UNITY_STANDALONE

        // PCだった場合にPC用の表示に切り替える
            case (int)Page.Page1:
                operateImage[0].SetActive(true);
                operateImage[1].SetActive(false);
                operateImage[2].SetActive(false);
                operateText_PC[0].SetActive(true);
                operateText_PC[1].SetActive(false);
                operateText_PC[2].SetActive(false);
                break;
            case (int)Page.Page2:
                operateImage[0].SetActive(false);
                operateImage[1].SetActive(true);
                operateImage[2].SetActive(false);
                operateText_PC[0].SetActive(false);
                operateText_PC[1].SetActive(true);
                operateText_PC[2].SetActive(false);
                break;
            case (int)Page.Page3:
                operateImage[0].SetActive(false);
                operateImage[1].SetActive(false);
                operateImage[2].SetActive(true);
                operateText_PC[0].SetActive(false);
                operateText_PC[1].SetActive(false);
                operateText_PC[2].SetActive(true);
                break;

#endif

#if UNITY_ANDROID

            // androidだった場合にandroid用の表示に切り替える
            case (int)Page.Page1:
                operateImage[0].SetActive(true);
                operateImage[1].SetActive(false);
                operateImage[2].SetActive(false);
                operateText_Android[0].SetActive(true);
                operateText_Android[1].SetActive(false);
                operateText_Android[2].SetActive(false);
                break;
            case (int)Page.Page2:
                operateImage[0].SetActive(false);
                operateImage[1].SetActive(true);
                operateImage[2].SetActive(false);
                operateText_Android[0].SetActive(false);
                operateText_Android[1].SetActive(true);
                operateText_Android[2].SetActive(false);
                break;
            case (int)Page.Page3:
                operateImage[0].SetActive(false);
                operateImage[1].SetActive(false);
                operateImage[2].SetActive(true);
                operateText_Android[0].SetActive(false);
                operateText_Android[1].SetActive(false);
                operateText_Android[2].SetActive(true);
            break;
#endif
        }
    }

    private void StageHelp()
    {
        stageImageNum = PlayerPrefs.GetInt("STAGEHELP", 0);
        if (stageImageNum > 2)
        {
            stageImageNum = 1;
        }
        if (stageImageNum < 1)
        {
            stageImageNum = 2;
        }
        switch (stageImageNum)
        {
            case (int)Page.Page1:
                stageImage[0].SetActive(true);
                stageImage[1].SetActive(false);
                break;
            case (int)Page.Page2:
                stageImage[0].SetActive(false);
                stageImage[1].SetActive(true);
                break;
        }
    }

    public void OnClickHelpLeftButton()
    {
        switch (helpNum)
        {
            case (int)Help.Game:
                gameImageNum -= 1;
                PlayerPrefs.SetInt("GAMEHELP", gameImageNum);
                GameHelp();
                break;
            case (int)Help.Operate:
                operateImageNum -= 1;
                PlayerPrefs.SetInt("OPERATEHELP", operateImageNum);
                OperateHelp();
                break;
            case (int)Help.Stage:
                stageImageNum -= 1;
                PlayerPrefs.SetInt("STAGEHELP", stageImageNum);
                StageHelp();
                break;
        }
    }

    public void OnClickHelpRightButton()
    {
        switch (helpNum)
        {
            case (int)Help.Game:
                gameImageNum += 1;
                PlayerPrefs.SetInt("GAMEHELP", gameImageNum);
                GameHelp();
                break;
            case (int)Help.Operate:
                operateImageNum += 1;
                PlayerPrefs.SetInt("OPERATEHELP", operateImageNum);
                OperateHelp();
                break;
            case (int)Help.Stage:
                stageImageNum += 1;
                PlayerPrefs.SetInt("STAGEHELP", stageImageNum);
                StageHelp();
                break;
        }
    }
}
