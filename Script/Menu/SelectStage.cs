using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectStage : MonoBehaviour
{
    private int stage;
    private int lockStage;

    private bool[] unlockStage = { false, false, false, false, false, false, false, false, false };

    public Button[] stageBtn;

    public static class SettingData
    {
        public static bool GetBool(string key, bool defalutValue)
        {
            var value = PlayerPrefs.GetInt(key, defalutValue ? 1 : 0);
            return value == 1;
        }

        public static void SetBool(string key, bool value)
        {
            PlayerPrefs.SetInt(key, value ? 1 : 0);
        }
    }

    // 最初はステージ1しか選択出来ない
    void Start()
    {
        stageBtn[0].interactable = true;

        // ステージ1以外のボタンを入力無効にする
        for (int i = 1; i < 10; i++)
        {
            stageBtn[i].interactable = false;
        }
    }

    
    void Update()
    {
        stage = PlayerPrefs.GetInt("STAGE", 0);
        lockStage = PlayerPrefs.GetInt("NEXT", 0);

        UnlockStage();
    }

    // ステージの解放などの処理
    private void UnlockStage()
    {
        unlockStage[0] = SettingData.GetBool("UNLOCK1", false);
        unlockStage[1] = SettingData.GetBool("UNLOCK2", false);
        unlockStage[2] = SettingData.GetBool("UNLOCK3", false);
        unlockStage[3] = SettingData.GetBool("UNLOCK4", false);
        unlockStage[4] = SettingData.GetBool("UNLOCK5", false);
        unlockStage[5] = SettingData.GetBool("UNLOCK6", false);
        unlockStage[6] = SettingData.GetBool("UNLOCK7", false);
        unlockStage[7] = SettingData.GetBool("UNLOCK8", false);
        unlockStage[8] = SettingData.GetBool("UNLOCK9", false);

        // ステージ1クリア後にステージ2を解放する
        if (lockStage >= 2 || unlockStage[0] == true)
        {
            stageBtn[1].interactable = true;
            SettingData.SetBool("UNLOCK1", true);
        }
        if (lockStage >= 3 || unlockStage[1] == true)
        {
            stageBtn[2].interactable = true;
            SettingData.SetBool("UNLOCK2", true);
        }
        if (lockStage >= 4 || unlockStage[2] == true)
        {
            stageBtn[3].interactable = true;
            SettingData.SetBool("UNLOCK3", true);
        }
        if (lockStage >= 5 || unlockStage[3] == true)
        {
            stageBtn[4].interactable = true;
            SettingData.SetBool("UNLOCK4", true);
        }
        if (lockStage >= 6 || unlockStage[4] == true)
        {
            stageBtn[5].interactable = true;
            SettingData.SetBool("UNLOCK5", true);
        }
        if (lockStage >= 7 || unlockStage[5] == true)
        {
            stageBtn[6].interactable = true;
            SettingData.SetBool("UNLOCK6", true);
        }
        if (lockStage >= 8 || unlockStage[6] == true)
        {
            stageBtn[7].interactable = true;
            SettingData.SetBool("UNLOCK7", true);
        }
        if (lockStage >= 9 || unlockStage[7] == true)
        {
            stageBtn[8].interactable = true;
            SettingData.SetBool("UNLOCK8", true);
        }
        if (lockStage >= 10 || unlockStage[8] == true)
        {
            stageBtn[9].interactable = true;
            SettingData.SetBool("UNLOCK9", true);
        }
    }

    // ステージセレクトのボタンごとにステージを表示する為の数字が割り振られている
    public void onClickStageButton1()
    {
        stage = 1;
        PlayerPrefs.SetInt("STAGE", stage);
    }

    public void onClickStageButton2()
    {
        stage = 2;
        PlayerPrefs.SetInt("STAGE", stage);
    }

    public void onClickStageButton3()
    {
        stage = 3;
        PlayerPrefs.SetInt("STAGE", stage);
    }

    public void onClickStageButton4()
    {
        stage = 4;
        PlayerPrefs.SetInt("STAGE", stage);
    }

    public void onClickStageButton5()
    {
        stage = 5;
        PlayerPrefs.SetInt("STAGE", stage);
    }

    public void onClickStageButton6()
    {
        stage = 6;
        PlayerPrefs.SetInt("STAGE", stage);
    }

    public void onClickStageButton7()
    {
        stage = 7;
        PlayerPrefs.SetInt("STAGE", stage);
    }

    public void onClickStageButton8()
    {
        stage = 8;
        PlayerPrefs.SetInt("STAGE", stage);
    }

    public void onClickStageButton9()
    {
        stage = 9;
        PlayerPrefs.SetInt("STAGE", stage);
    }

    public void onClickStageButton10()
    {
        stage = 10;
        PlayerPrefs.SetInt("STAGE", stage);
    }
}
