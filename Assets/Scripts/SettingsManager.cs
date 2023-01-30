using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;
using Unity.VisualScripting;

public class SettingsManager : MonoBehaviour
{
    public RectTransform top;
    public RectTransform bottom;
    public RectTransform left;
    public RectTransform right;

    public float valueY = 10;
    public TMP_Text textToShow;

    public void crosshairlenghtPlus()
    {
        textToShow.text = valueY.ToString();

        top.transform.Translate(Vector3.right);
        top.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueY++);

        bottom.transform.Translate(Vector3.left);
        bottom.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueY++);
    }

    public void crosshairlenghtMinus()
    {
        textToShow.text = valueY.ToString();
        top.transform.Translate(Vector3.left / 2);
        top.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, valueY--);
    }
}