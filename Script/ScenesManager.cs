using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    private int nextStage;

    // �^�C�g����ʑJ�ڂ̃{�^���ɃA�^�b�`
    public void OnClickTitleButton()
    {
        Time.timeScale = 1.0f;
        Invoke("ChangeTitleScene", 1.0f);
    }

    // �^�C�g����ʂɑJ��
    private void ChangeTitleScene()
    {
        SceneManager.LoadScene("TitleScenes");
    }

    // �X�e�[�W�Q�[����ʑJ�ڂ̃{�^���ɃA�^�b�`
    public void OnClickStageGameButton()
    {
        Time.timeScale = 1.0f;
        Invoke("ChangeStageGameScene", 1.0f);
    }

    // �X�e�[�W�Q�[����ʂɑJ��
    private void ChangeStageGameScene()
    {
        SceneManager.LoadScene("StageGameScenes");
    }

    // �N���A��ʂ̎��̃X�e�[�W�֑J�ڂ̃{�^���ɃA�^�b�`
    public void OnClickNextStageButton()
    {
        nextStage = PlayerPrefs.GetInt("NEXT", 0);
        PlayerPrefs.SetInt("STAGE", nextStage);
        Invoke("ChangeNextStageScene", 1.0f);
    }

    // �N���A��ʂ��玟�̃X�e�[�W��ʂɑJ��
    private void ChangeNextStageScene()
    {
        SceneManager.LoadScene("StageGameScenes");
    }

    // �G���h���X�Q�[����ʑJ�ڂ̃{�^���ɃA�^�b�`
    public void OnClickEndlessGameButton()
    {
        Time.timeScale = 1.0f;
        Invoke("ChangeEndlessGameScene", 1.0f);
    }

    // �G���h���X�Q�[����ʂɑJ��
    private void ChangeEndlessGameScene()
    {
        SceneManager.LoadScene("EndlessGameScenes");
    }

    // ���������ʑJ�ڂ̃{�^���ɃA�^�b�`
    public void OnClickHelpButton()
    {
        Invoke("ChangeHelpScene", 1.0f);
    }

    // ���������ʂɑJ��
    private void ChangeHelpScene()
    {
        SceneManager.LoadScene("HelpScenes");
    }

    // �X�L���ύX��ʑJ�ڂ̃{�^���ɃA�^�b�`
    public void OnClickSkinButton()
    {
        Invoke("ChangeSkinScene", 1.0f);
    }

    // �X�L���ύX��ʂɑJ��
    private void ChangeSkinScene()
    {
        SceneManager.LoadScene("SkinScenes");
    }

    // �����L���O��ʑJ�ڂ̃{�^���ɃA�^�b�`
    public void OnClickRankingButton()
    {
        Invoke("ChangeRankingScene", 1.0f);
    }

    // �����L���O��ʂɑJ��
    private void ChangeRankingScene()
    {
        SceneManager.LoadScene("RankingScenes");
    }

    // �Q�[�����I���{�^��
    public void ExitButton()
    {
        Application.Quit();
    }
}