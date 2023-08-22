using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySE : MonoBehaviour
{
    AudioClip clip;

    void Start()
    {
        // Component���擾
        clip = gameObject.GetComponent<AudioSource>().clip;
    }

    // ��x����SE��炷
    public void PlayStart()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
