using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSkin : MonoBehaviour
{
    private int skinNum;

    public Animator[] playerSkin;

    void Start()
    {
        playerSkin[0] = GetComponent<Animator>();

        skinNum = PlayerPrefs.GetInt("SKIN", 0);
    
        switch (skinNum)
        {
            case 1:
                playerSkin[0].runtimeAnimatorController = playerSkin[1].runtimeAnimatorController;
                break;
            case 2:
                playerSkin[0].runtimeAnimatorController = playerSkin[2].runtimeAnimatorController;
                break;
            case 3:
                playerSkin[0].runtimeAnimatorController = playerSkin[3].runtimeAnimatorController;
                break;
            case 4:
                playerSkin[0].runtimeAnimatorController = playerSkin[4].runtimeAnimatorController;
                break;
            case 5:
                playerSkin[0].runtimeAnimatorController = playerSkin[5].runtimeAnimatorController;
                break;
        }
    }
}
