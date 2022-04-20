using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioSource birdSound;
    // Start is called before the first frame update
    void Start()
    {
        birdSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void playSound()
    {
        birdSound.Play();
    }
       
}
