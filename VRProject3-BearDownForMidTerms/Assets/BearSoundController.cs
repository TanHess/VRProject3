using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearSoundController : MonoBehaviour
{
    private Animator animator;
    public AudioClip snarl;
    public AudioClip idle;
    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaySnarl() {
        sound.PlayOneShot(Resources.Load<AudioClip>("Sounds/Snarl"), 1.0f);
    }
    void PlayIdle(){
        sound.PlayOneShot(Resources.Load<AudioClip>("Sounds/BearIdle"),0.75f);
    }
    void PlayEat() {
        sound.PlayOneShot(Resources.Load<AudioClip>("Sounds/EatingSound"),1.0f);
    }
    void PlayConfused() {
        sound.PlayOneShot(Resources.Load<AudioClip>("Sounds/BearConfused"),1.0f);
    }
    void PlaySleeping() {
        sound.PlayOneShot(Resources.Load<AudioClip>("Sounds/BearSnoring"),1.0f);
    }
}
