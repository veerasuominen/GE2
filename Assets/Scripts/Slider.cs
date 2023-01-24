using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Slider : MonoBehaviour
{
    //slider
    [SerializeField] private Slider sliderControl;
    [SerializeField] private TMP_InputField inputControl;
    [SerializeField] private TMP_Text textToShow;
    [SerializeField] private Image crosshair;
    [SerializeField] private RectTransform crosshairDim;
    [SerializeField] private int number;

    void Start()
    {
        sliderControl = GetComponentInChildren<Slider>();
        inputControl = GetComponentInChildren<TMP_InputField>();
        textToShow = GetComponentInChildren<TMP_Text>();
        crosshair = GetComponentInChildren<Image>();
        crosshairDim = crosshair.rectTransform;
    }

    private void Update()
    {
        
    }

    public void ChangeSomeValue(float value)
    {
        
        textToShow.text = value.ToString();
        crosshairDim.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, value);
        crosshairDim.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, value);
    }
}
