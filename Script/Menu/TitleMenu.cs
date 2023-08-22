using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleMenu : MonoBehaviour
{
    [SerializeField] GameObject TitleText;
    [SerializeField] GameObject[] Menu;

    // �^�C�g��������\��
    void Start()
    {
        TitleText.SetActive(true);
    }

    // �^�C�g���̃��j���[��\��
    public void OnClickTitleMenuButton()
    {
        Menu[0].SetActive(true);
        Menu[1].SetActive(false);
        Menu[2].SetActive(false);
    }

    // �Q�[�����[�h�̑I����\��
    public void OnClickSelectGameButton()
    {
        Menu[0].SetActive(false);
        Menu[1].SetActive(true);
        Menu[2].SetActive(false);
    }

    // �X�e�[�W���[�h�̑I����\��
    public void OnClickSelectStageButton()
    {
        Menu[0].SetActive(false);
        Menu[1].SetActive(false);
        Menu[2].SetActive(true);
    }
}
