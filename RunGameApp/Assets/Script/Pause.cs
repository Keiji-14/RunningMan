using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool pauseNow = false;

    [SerializeField] GameObject pauseMenu;

    public void OnClickPauseButton()
    {
        pauseNow = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void OnClickGameBackButton()
    {
        pauseNow = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
