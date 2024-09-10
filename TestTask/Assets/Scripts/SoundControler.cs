using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundControler : MonoBehaviour
{
    public AudioSource MainMusic;
    
    
    private void Awake()
    {
        MainMusic.Play();
        
    }
    
}
