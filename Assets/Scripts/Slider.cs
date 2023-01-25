using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Slider : MonoBehaviour
{
    //slider
    public Slider reticleSlider;

    [SerializeField] private TMP_InputField inputControl;
    [SerializeField] private TMP_Text textToShow;
    [SerializeField] private Image reticle;

    [SerializeField] private RectTransform crosshairDim;

    private void Start()
    {
        reticleSlider = GetComponentInChildren<Slider>();
        inputControl = GetComponentInChildren<TMP_InputField>();
        textToShow = GetComponentInChildren<TMP_Text>();
        crosshairDim = reticle.rectTransform;
    }

    public void ChangeSomeValue(float value)
    {
        textToShow.text = value.ToString();
        crosshairDim.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, value);
        crosshairDim.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, value);
    }
}