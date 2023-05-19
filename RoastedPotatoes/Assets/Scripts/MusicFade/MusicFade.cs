using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicFade : MonoBehaviour
{
    Animator _musicAnim;

    private void Start()
    {
        _musicAnim = GetComponent<Animator>();
    }

    public void FadeMusic()
    {
        _musicAnim.SetBool("FadeMusic", true);
    }
}
