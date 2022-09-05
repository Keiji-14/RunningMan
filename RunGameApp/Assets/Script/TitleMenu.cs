using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleMenu : MonoBehaviour
{
    [SerializeField] GameObject TitleText;
    [SerializeField] GameObject[] Menu;

    // タイトル文字を表示
    void Start()
    {
        TitleText.SetActive(true);
    }

    // タイトルのメニューを表示
    public void OnClickTitleMenuButton()
    {
        Menu[0].SetActive(true);
        Menu[1].SetActive(false);
        Menu[2].SetActive(false);
    }

    // ゲームモードの選択を表示
    public void OnClickSelectGameButton()
    {
        Menu[0].SetActive(false);
        Menu[1].SetActive(true);
        Menu[2].SetActive(false);
    }

    // ステージモードの選択を表示
    public void OnClickSelectStageButton()
    {
        Menu[0].SetActive(false);
        Menu[1].SetActive(false);
        Menu[2].SetActive(true);
    }
}
