using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    private AudioClip clip;

    public void PlayMusic()
    {
        audioSource.Stop();
        clip = Resources.Load<AudioClip>("PiratasDelCaribe");
        audioSource.clip = clip;
        audioSource.Play();
    }


}
