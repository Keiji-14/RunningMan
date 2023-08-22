using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBackGround : MonoBehaviour
{
    public float setScrollSpeed;
    private float countTime = 3.0f;

    private GameObject playerObject;

    Player player;

    // 背景をスクロールする為の処理
    void Update()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        player = playerObject.GetComponent<Player>();
        countTime -= Time.deltaTime;

        if (countTime <= 0.0f)
        {
            // プレイヤーが死ぬまではスクロールし続ける
            if (!player.stageDeadFlag &&
                !player.endlessDeadFlag &&
                !player.stageClearFlag)
            {
                transform.position -= new Vector3(setScrollSpeed, 0, 0) * Time.deltaTime;

                if (transform.position.x <= -3000)
                {
                    transform.position = new Vector3(3000.0f, 0.0f, 0.0f);
                }
            }
        }
    }
}
