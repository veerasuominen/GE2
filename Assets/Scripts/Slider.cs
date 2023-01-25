using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Slider : MonoBehaviour
{
    //slider
    [SerializeField] private Slider reticleSlider;
    [SerializeField] private Slider lenght;
    [SerializeField] private Slider width;
    [SerializeField] private TMP_InputField inputControl;
    [SerializeField] private TMP_Text textToShow;
    [SerializeField] private Image reticle;
    [SerializeField] private Image crosshairTop;
    [SerializeField] private Image crosshairBottom;
    [SerializeField] private Image crosshairRight;
    [SerializeField] private Image crosshairLeft;
    

    [SerializeField] private RectTransform crosshairDim;
    [SerializeField] private int number;

    void Start()
    {
        reticleSlider = GetComponentInChildren<Slider>();
        inputControl = GetComponentInChildren<TMP_InputField>();
        textToShow = GetComponentInChildren<TMP_Text>();
        //reticle = GetComponentInChildren<Image>();
        //crosshairTop = GetComponentInChildren<Image>();
        //crosshairBottom = GetComponentInChildren<Image>();
        //crosshairRight = GetComponentInChildren<Image>();
        //crosshairLeft = GetComponentInChildren<Image>();

        crosshairDim = reticle.rectTransform;
    }


    public void ChangeSomeValue(float value)
    {
        
        textToShow.text = value.ToString();
        crosshairDim.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, value);
        crosshairDim.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, value);
    }
}
