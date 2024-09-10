using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensivitySettings : VolumeSettings
{
    public GameObject Ball;
    private const int MULTIPLIER = 100;
    protected override void Awake()
    {
        Scrollbar.onValueChanged.AddListener(HandlerSliderValueChanged);
    }
    protected override void HandlerSliderValueChanged(float value)
    {
        float sensivityValue = value * MULTIPLIER;
        Ball.GetComponent<Ball>().speed = sensivityValue;
    }
}
