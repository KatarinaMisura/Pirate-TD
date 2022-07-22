using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuMusic : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    private AudioClip clip;

    private void Start()
    {
        clip = Resources.Load<AudioClip>("arghMatey");
        PlayMusic();
    }

    public void PlayMusic()
    { 
        audioSource.clip = clip;
        audioSource.Play(); 
    }




}
