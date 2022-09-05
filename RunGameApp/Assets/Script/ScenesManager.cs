using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    private int nextStage;

    // タイトル画面遷移のボタンにアタッチ
    public void OnClickTitleButton()
    {
        Time.timeScale = 1.0f;
        Invoke("ChangeTitleScene", 1.0f);
    }

    // タイトル画面に遷移
    private void ChangeTitleScene()
    {
        SceneManager.LoadScene("TitleScenes");
    }

    // ステージゲーム画面遷移のボタンにアタッチ
    public void OnClickStageGameButton()
    {
        Time.timeScale = 1.0f;
        Invoke("ChangeStageGameScene", 1.0f);
    }

    // ステージゲーム画面に遷移
    private void ChangeStageGameScene()
    {
        SceneManager.LoadScene("StageGameScenes");
    }

    // クリア画面の次のステージへ遷移のボタンにアタッチ
    public void OnClickNextStageButton()
    {
        nextStage = PlayerPrefs.GetInt("NEXT", 0);
        PlayerPrefs.SetInt("STAGE", nextStage);
        Invoke("ChangeNextStageScene", 1.0f);
    }

    // クリア画面から次のステージ画面に遷移
    private void ChangeNextStageScene()
    {
        SceneManager.LoadScene("StageGameScenes");
    }

    // エンドレスゲーム画面遷移のボタンにアタッチ
    public void OnClickEndlessGameButton()
    {
        Time.timeScale = 1.0f;
        Invoke("ChangeEndlessGameScene", 1.0f);
    }

    // エンドレスゲーム画面に遷移
    private void ChangeEndlessGameScene()
    {
        SceneManager.LoadScene("EndlessGameScenes");
    }

    // 操作説明画面遷移のボタンにアタッチ
    public void OnClickHelpButton()
    {
        Invoke("ChangeHelpScene", 1.0f);
    }

    // 操作説明画面に遷移
    private void ChangeHelpScene()
    {
        SceneManager.LoadScene("HelpScenes");
    }

    // スキン変更画面遷移のボタンにアタッチ
    public void OnClickSkinButton()
    {
        Invoke("ChangeSkinScene", 1.0f);
    }

    // スキン変更画面に遷移
    private void ChangeSkinScene()
    {
        SceneManager.LoadScene("SkinScenes");
    }

    // ランキング画面遷移のボタンにアタッチ
    public void OnClickRankingButton()
    {
        Invoke("ChangeRankingScene", 1.0f);
    }

    // ランキング画面に遷移
    private void ChangeRankingScene()
    {
        SceneManager.LoadScene("RankingScenes");
    }

    // ゲームを終了ボタン
    public void ExitButton()
    {
        Application.Quit();
    }
}