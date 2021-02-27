using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;

    public void SetBeginingProgress(int maxScore)
    {
        slider.maxValue = maxScore;
        slider.value = 0;
    }
    public void SetProgress(int score)
    {
        slider.value = score;
    }
}
