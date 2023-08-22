using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySE : MonoBehaviour
{
    AudioClip clip;

    void Start()
    {
        // Componentを取得
        clip = gameObject.GetComponent<AudioSource>().clip;
    }

    // 一度だけSEを鳴らす
    public void PlayStart()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
