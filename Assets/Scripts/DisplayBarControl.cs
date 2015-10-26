using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayBarControl : MonoBehaviour {

    public RectTransform bar;
    public Image barImage;
    public Image downArrow;
    public Image upArrow;
    public Color upColor;
    public Color midColor;
    public Color downColor;
    public float maxWidth = 180;
    public float maxValue = 180;
    
    public void SetValue(float value)
    {
        if (value > maxValue) value = maxValue;
        UpdateWidth(value);
        UpdateColour(value);
    }

    public void FlashUp()
    {

    }

    public void FlashDown()
    {

    }
	
    private void UpdateWidth(float value)
    {
        float width = maxWidth * (value / maxValue);
        bar.sizeDelta = new Vector2 (width, bar.sizeDelta.y);
    }

    private void UpdateColour(float value)
    {
        float halfMax = maxValue / 2;
        if (value > halfMax)
        {
            float ratio = (value - halfMax) / halfMax;
            barImage.color = Color.Lerp(midColor, upColor, ratio);
        }
        else
        {
            float ratio = value / halfMax;
            barImage.color = Color.Lerp(downColor, midColor, ratio);
        }
    }


}
