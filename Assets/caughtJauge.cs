﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caughtJauge : MonoBehaviour
{
    public bool seen = false;
    public float increaseRate = 10;
    public float decreaseRate = 10;

    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (seen)
        {
            if (slider.value < 1)
                slider.value += 0.01f * increaseRate;
            else
                HandleDeath();
        }
        else
        {
            if(slider.value > 0)
            {
                slider.value -= 0.01f * decreaseRate;
            }
        }
    }

    void HandleDeath()
    {

    }
}
