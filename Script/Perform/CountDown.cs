using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float countTime = 3.5f;

    public Button pauseButton;

    public Text countText;
    public GameObject goObject;
    public GameObject countDownObject;

    void Start()
    {
        pauseButton.interactable = false;
    }

    // �J�E���g�_�E����Go�̕\���̏���
    void Update()
    {
        countTime -= Time.deltaTime;
        countText.text = countTime.ToString("0");

        if (countTime <= 0.5f)
        {
            pauseButton.interactable = true;
            countDownObject.SetActive(false);
            goObject.SetActive(true);
        }
        // �J�E���g�_�E����GO�̕\�����������������
        if (countTime <= -1.0f)
        {
            goObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
