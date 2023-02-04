using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;
using Unity.VisualScripting;

public class SettingsManager : MonoBehaviour
{
    public TMP_Text textToShowLenght, textToShowWidth, textToShowOffset;

    public RectTransform top, bottom, right, left;
    public float valueY = 10, valueX = 2, offset = 3, reticleFloat = 1;
    public Image reticle;
    public Vector2 reticleSize;

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

    public void OffsetPlus()
    {
        offset++;
        top.transform.Translate(Vector3.up);
        bottom.transform.Translate(Vector3.down);
        left.transform.Translate(Vector3.right);
        right.transform.Translate(Vector3.left);
    }

    public void OffsetMinus()
    {
        offset--;
        top.transform.Translate(Vector3.down);
        bottom.transform.Translate(Vector3.up);
        left.transform.Translate(Vector3.left);
        right.transform.Translate(Vector3.right);
    }

    public void ReticlePlus()
    {
        reticleFloat++;
        reticle.rectTransform.localScale = new Vector2(reticleFloat, reticleFloat);
    }

    public void ReticleMinus()
    {
        reticleFloat--;
        reticle.rectTransform.localScale = new Vector2(reticleFloat, reticleFloat);
    }
}