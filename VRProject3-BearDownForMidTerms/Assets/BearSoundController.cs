using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearSoundController : MonoBehaviour
{
    private Animator animator;
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
        if (Random.Range(0,100) == 50){
            sound.Play();
        }
        
    }

    void PlayGrowl() {
        sound.Play();
    }
}
