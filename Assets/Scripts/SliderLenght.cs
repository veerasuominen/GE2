using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class SliderLenght : MonoBehaviour
{
    [SerializeField] private Slider lenghtSlider;
    [SerializeField] private TMP_Text label;
    [SerializeField] private TMP_Text textToShow;

    [SerializeField] private Image reticle;
    [SerializeField] private Image crosshairTop;
    [SerializeField] private Image crosshairBottom;
    [SerializeField] private Image crosshairRight;
    [SerializeField] private Image crosshairLeft;

    [SerializeField] private RectTransform crosshairLenghtRect;

    private void Start()
    {
        //lenghtSlider = GetComponent<Slider>();
        //textToShow = GetComponentInChildren<TMP_Text>();
        crosshairLenghtRect = crosshairTop.rectTransform;
    }

    public void ChangeSomeValue(float value)
    {
        textToShow.text = value.ToString();

        crosshairTop.rectTransform.anchorMax = crosshairTop.transform.localPosition;
        crosshairLenghtRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, value);
    }
}