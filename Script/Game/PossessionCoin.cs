using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PossessionCoin : MonoBehaviour
{
    private int getCoin;
    public Text coinText;

    // コインの所持数の表示する処理
    void Update()
    {
        getCoin = PlayerPrefs.GetInt("COIN", 0);
        coinText.text = getCoin.ToString("000");
    }
}
