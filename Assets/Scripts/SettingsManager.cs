using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;
using Unity.VisualScripting;

public class SettingsManager : MonoBehaviour
{
    public TMP_Text textToShowLenght;
    public TMP_Text textToShowWidth;

    public RectTransform top;
    public RectTransform bottom;
    public RectTransform left;
    public RectTransform right;

    public float valueY = 10;
    public float valueX = 2;

    private void Start()
    {
    }

    private void Update()
    {
        textToShowLenght.text = valueY.ToString();
        textToShowWidth.text = valueX.ToString();
    }

    public void CrosshairlenghtPlus()
    {
        valueY = valueY + 2;
        top.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, valueY);
        bottom.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, valueY);
        left.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueY);
        right.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueY);
    }

    public void CrosshairlenghtMinus()
    {
        valueY = valueY - 2;
        top.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, valueY);
        bottom.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, valueY);
        right.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueY);
        left.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueY);
    }

    public void CrosshairWidthPlus()
    {
        valueX++;
        top.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueX);
        bottom.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueX);
        left.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, valueX);
        right.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, valueX);
    }

    public void CrosshairWidthMinus()
    {
        valueX--;
        top.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueX);
        bottom.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueX);
        left.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, valueX);
        right.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, valueX);
    }
}