using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CreateStage : MonoBehaviour
{
    private int stageNum = 0;
    private int countNum = 0;
    private int createBorder = 45;
    private float createPos = 0;

    private GameObject playerObject;
    [SerializeField] GameObject[] stage;

    Player player;

    void Update()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        player = playerObject.GetComponent<Player>();
        createPos = player.position;

        // エンドレスモードのステージを45進むごとにランダム作成
        if (createPos > countNum * createBorder)
        {
            countNum += 1;
            stageNum = Random.Range(0, 4);
            switch (stageNum)
            {
                case 0:
                    Instantiate(stage[0], new Vector3(countNum * createBorder, 0, 0), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(stage[1], new Vector3(countNum * createBorder, 0, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(stage[2], new Vector3(countNum * createBorder, 0, 0), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(stage[3], new Vector3(countNum * createBorder, 0, 0), Quaternion.identity);
                    break;
            }
        }
    }
}