using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSkin : MonoBehaviour
{
    public int lockSkinNum;
    private int skin;
    private int skinPage;
    private int possessionCoin;

    private bool[] unlockSkin = { false, false, false, false, false, false};

    public Button skinBtn1;
    public Button skinBtn2;
    public Button skinBtn3;
    public Button skinBtn4;
    public Button skinBtn5;
    public Button skinBtn6;

    public Text skinPageCountText;

    public GameObject[] Lock_Object;
    public GameObject[] Unlock_Object;

    [SerializeField] GameObject[] SkinPage;

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

    void Start()
    {
        skinPage = 1;

        // 始めにスキンの選択を不可にする
        skinBtn1.interactable = false;
        skinBtn2.interactable = false;
        skinBtn3.interactable = false;
        skinBtn4.interactable = false;
        skinBtn5.interactable = false;
        skinBtn6.interactable = false;
    }

    // スキン変更画面のスキン選択の処理
    void Update()
    {
        skin = PlayerPrefs.GetInt("SKIN", 0);
        possessionCoin = PlayerPrefs.GetInt("COIN", 0);

        SelectSkinPage();
        UnlockSkin();

        unlockSkin[0] = SettingData.GetBool("UNLOCKSKIN1", false);
        unlockSkin[1] = SettingData.GetBool("UNLOCKSKIN2", false);
        unlockSkin[2] = SettingData.GetBool("UNLOCKSKIN3", false);
        unlockSkin[3] = SettingData.GetBool("UNLOCKSKIN4", false);
        unlockSkin[4] = SettingData.GetBool("UNLOCKSKIN5", false);

        switch (skin)
        {
            case 0:
                skinBtn1.interactable = false;
                if (unlockSkin[0])
                {
                    skinBtn2.interactable = true;
                }
                if (unlockSkin[1])
                {
                    skinBtn3.interactable = true;
                }
                if (unlockSkin[2])
                {
                    skinBtn4.interactable = true;
                }
                if (unlockSkin[3])
                {
                    skinBtn5.interactable = true;
                }
                if (unlockSkin[4])
                {
                    skinBtn6.interactable = true;
                }
                break;
            case 1:
                skinBtn1.interactable = true;
                skinBtn2.interactable = false;
                if (unlockSkin[1])
                {
                    skinBtn3.interactable = true;
                }
                if (unlockSkin[2])
                {
                    skinBtn4.interactable = true;
                }
                if (unlockSkin[3])
                {
                    skinBtn5.interactable = true;
                }
                if (unlockSkin[4])
                {
                    skinBtn6.interactable = true;
                }
                break;
            case 2:
                skinBtn1.interactable = true;
                skinBtn2.interactable = true;
                skinBtn3.interactable = false;
                if (unlockSkin[2])
                {
                    skinBtn4.interactable = true;
                }
                if (unlockSkin[3])
                {
                    skinBtn5.interactable = true;
                }
                if (unlockSkin[4])
                {
                    skinBtn6.interactable = true;
                }
                break;
            case 3:
                skinBtn1.interactable = true;
                skinBtn2.interactable = true;
                skinBtn3.interactable = true;
                skinBtn4.interactable = false;
                if (unlockSkin[3])
                {
                    skinBtn5.interactable = true;
                }
                if (unlockSkin[4])
                {
                    skinBtn6.interactable = true;
                }
                break;
            case 4:
                skinBtn1.interactable = true;
                skinBtn2.interactable = true;
                skinBtn3.interactable = true;
                skinBtn4.interactable = true;
                skinBtn5.interactable = false;
                if (unlockSkin[4])
                {
                    skinBtn6.interactable = true;
                }
                break;
            case 5:
                skinBtn1.interactable = true;
                skinBtn2.interactable = true;
                skinBtn3.interactable = true;
                skinBtn4.interactable = true;
                skinBtn5.interactable = true;
                skinBtn6.interactable = false;
                break;
        }

       /* switch (skin)
        {
            case 0:
                skinBtn1.interactable = false;
                if (possessionCoin >= 50)
                {
                    skinBtn2.interactable = true;
                }
                else
                {
                    skinBtn2.interactable = false;
                }
                if (possessionCoin >= 100)
                {
                    skinBtn3.interactable = true;
                }
                else
                {
                    skinBtn3.interactable = false;
                }
                if (possessionCoin >= 150)
                {
                    skinBtn4.interactable = true;
                }
                else
                {
                    skinBtn4.interactable = false;
                }
                if (possessionCoin >= 200)
                {
                    skinBtn5.interactable = true;
                }
                else
                {
                    skinBtn5.interactable = false;
                }
                if (possessionCoin >= 250)
                {
                    skinBtn6.interactable = true;
                }
                else
                {
                    skinBtn6.interactable = false;
                }
                break;
            case 1:
                skinBtn1.interactable = true;
                skinBtn2.interactable = false;
                if (possessionCoin >= 100)
                {
                    skinBtn3.interactable = true;
                }
                else
                {
                    skinBtn3.interactable = false;
                }
                if (possessionCoin >= 150)
                {
                    skinBtn4.interactable = true;
                }
                else
                {
                    skinBtn4.interactable = false;
                }
                if (possessionCoin >= 200)
                {
                    skinBtn5.interactable = true;
                }
                else
                {
                    skinBtn5.interactable = false;
                }
                if (possessionCoin >= 250)
                {
                    skinBtn6.interactable = true;
                }
                else
                {
                    skinBtn6.interactable = false;
                }
                break;
            case 2:
                skinBtn1.interactable = true;
                skinBtn2.interactable = true;
                skinBtn3.interactable = false;
                if (possessionCoin >= 150)
                {
                    skinBtn4.interactable = true;
                }
                else
                {
                    skinBtn4.interactable = false;
                }
                if (possessionCoin >= 200)
                {
                    skinBtn5.interactable = true;
                }
                else
                {
                    skinBtn5.interactable = false;
                }
                if (possessionCoin >= 250)
                {
                    skinBtn6.interactable = true;
                }
                else
                {
                    skinBtn6.interactable = false;
                }
                break;
            case 3:
                skinBtn1.interactable = true;
                skinBtn2.interactable = true;
                skinBtn3.interactable = true;
                skinBtn4.interactable = false;
                if (possessionCoin >= 200)
                {
                    skinBtn5.interactable = true;
                }
                else
                {
                    skinBtn5.interactable = false;
                }
                if (possessionCoin >= 250)
                {
                    skinBtn6.interactable = true;
                }
                else
                {
                    skinBtn6.interactable = false;
                }
                break;
            case 4:
                skinBtn1.interactable = true;
                skinBtn2.interactable = true;
                skinBtn3.interactable = true;
                skinBtn4.interactable = true;
                skinBtn5.interactable = false;
                if (possessionCoin >= 250)
                {
                    skinBtn6.interactable = true;
                }
                else
                {
                    skinBtn6.interactable = false;
                }
                break;
            case 5:
                skinBtn1.interactable = true;
                skinBtn2.interactable = true;
                skinBtn3.interactable = true;
                skinBtn4.interactable = true;
                skinBtn5.interactable = true;
                skinBtn6.interactable = false;
                break;
        }*/
    }

    private void SelectSkinPage()
    {
        skinPageCountText.text = skinPage.ToString("0") + " / 2";
        //skinPage = PlayerPrefs.GetInt("SKINPAGE", 0);

        if (skinPage > 2)
        {
            skinPage = 1;
        }
        else if (skinPage < 1)
        {
            skinPage = 2;
        }
        switch (skinPage)
        {
            case 1:
                SkinPage[0].SetActive(true);
                SkinPage[1].SetActive(false);
                break;
            case 2:
                SkinPage[0].SetActive(false);
                SkinPage[1].SetActive(true);
                break;
        }
    }

    private void UnlockSkin()
    {
        // コインを50枚でスキン1を解放
        if (possessionCoin >= 50)
        {
            Lock_Object[0].SetActive(false);
            Unlock_Object[0].SetActive(true);
            SettingData.SetBool("UNLOCKSKIN1", true);
        }
        // コインを100枚でスキン2を解放
        if (possessionCoin >= 100)
        {
            Lock_Object[1].SetActive(false);
            Unlock_Object[1].SetActive(true);
            SettingData.SetBool("UNLOCKSKIN2", true);
        }
        // コインを150枚でスキン3を解放
        if (possessionCoin >= 150)
        {
            Lock_Object[2].SetActive(false);
            Unlock_Object[2].SetActive(true);
            SettingData.SetBool("UNLOCKSKIN3", true);
        }
        // コインを200枚でスキン4を解放
        if (possessionCoin >= 200)
        {
            Lock_Object[3].SetActive(false);
            Unlock_Object[3].SetActive(true);
            SettingData.SetBool("UNLOCKSKIN4", true);
        }
        // コインを250枚でスキン5を解放
        if (possessionCoin >= 250)
        {
            Lock_Object[4].SetActive(false);
            Unlock_Object[4].SetActive(true);
            SettingData.SetBool("UNLOCKSKIN5", true);
        }
    }

    public void onClickSkinLeftButton()
    {
        skinPage -= 1;
    }

    public void onClickSkinRightButton()
    {
        skinPage += 1;
    }

    public void onClickSkinButton1()
    {
        skin = 0;
        PlayerPrefs.SetInt("SKIN", skin);
    }

    public void onClickSkinButton2()   
    {
        skin = 1;
        PlayerPrefs.SetInt("SKIN", skin);
    }

    public void onClickSkinButton3()
    {
        skin = 2;
        PlayerPrefs.SetInt("SKIN", skin);
    }

    public void onClickSkinButton4()
    {
        skin = 3;
        PlayerPrefs.SetInt("SKIN", skin);
    }

    public void onClickSkinButton5()
    {
        skin = 4;
        PlayerPrefs.SetInt("SKIN", skin);
    }

    public void onClickSkinButton6()
    {
        skin = 5;
        PlayerPrefs.SetInt("SKIN", skin);
    }
}
