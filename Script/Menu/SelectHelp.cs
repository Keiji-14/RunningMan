using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectHelp : MonoBehaviour
{
    private int helpNum;
    private int resetPage= 1;

    [SerializeField] GameObject baseHelp;
    [SerializeField] GameObject[] help;

    // �Q�[���ɂ��Ă̐�����ʂ�\�����鏈��
    public void OnClickHelpButton1()
    {
        helpNum = 0;
        PlayerPrefs.SetInt("HELP", helpNum);
        PlayerPrefs.SetInt("GAMEHELP", resetPage);
        baseHelp.SetActive(false);
        help[helpNum].SetActive(true);
    }

    // ��������ɂ��Ă̐�����ʂ�\�����鏈��
    public void OnClickHelpButton2()
    {
        helpNum = 1;
        PlayerPrefs.SetInt("HELP", helpNum);
        PlayerPrefs.SetInt("OPERATEHELP", resetPage);
        baseHelp.SetActive(false);
        help[helpNum].SetActive(true);
    }

    // �G���h���X���[�h�ɂ��Ă̐�����ʂ�\�����鏈��
    public void OnClickHelpButton3()
    {
        helpNum = 2;
        PlayerPrefs.SetInt("HELP", helpNum);
        PlayerPrefs.SetInt("ENDLESSHELP", resetPage);
        baseHelp.SetActive(false);
        help[helpNum].SetActive(true);
    }

    // �X�e�[�W���[�h�ɂ��Ă̐�����ʂ�\�����鏈��
    public void OnClickHelpButton4()
    {
        helpNum = 3;
        PlayerPrefs.SetInt("HELP", helpNum);
        PlayerPrefs.SetInt("STAGEHELP", resetPage);
        baseHelp.SetActive(false);
        help[helpNum].SetActive(true);
    }

    // �X�L���ύX�ɂ��Ă̐�����ʂ�\�����鏈��
    public void OnClickHelpButton5()
    {
        helpNum = 4;
        PlayerPrefs.SetInt("HELP", helpNum);
        baseHelp.SetActive(false);
        help[helpNum].SetActive(true);
    }

    // �����L���O�ɂ��Ă̐�����ʂ�\�����鏈��
    public void OnClickHelpButton6()
    {
        helpNum = 5;
        PlayerPrefs.SetInt("HELP", helpNum);
        baseHelp.SetActive(false);
        help[helpNum].SetActive(true);
    }

    // ������ʂ���鏈��
    public void OnClickHelpBackButton()
    {
        baseHelp.SetActive(true);
        for (int i = 0; i <= 5; i++)
        {
            help[i].SetActive(false);
        }
    }
}
