using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySE : MonoBehaviour
{
    AudioClip clip;

    void Start()
    {
        // Component‚ðŽæ“¾
        clip = gameObject.GetComponent<AudioSource>().clip;
    }

    // ˆê“x‚¾‚¯SE‚ð–Â‚ç‚·
    public void PlayStart()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
