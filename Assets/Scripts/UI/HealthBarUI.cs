using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBarUI : MonoBehaviour
{
    public Slider sliderControl;

    private void Start()
    {
        sliderControl = GetComponentInChildren<Slider>();
    }
}