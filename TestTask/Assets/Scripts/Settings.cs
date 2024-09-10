using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public string Volume = "MasterVolume";
    public AudioMixer Mixer;
    public Scrollbar Scrollbar;
    private const float MULTIPLIER = 20f;
    protected virtual void Awake()
    {
        Scrollbar.onValueChanged.AddListener(HandlerSliderValueChanged);
    }
    protected virtual void HandlerSliderValueChanged(float value)
    {
        var volumeValue = Mathf.Log10(value+0.00000001f) * MULTIPLIER;
        Mixer.SetFloat(Volume, volumeValue);
    }

}
