using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FlashFade : MonoBehaviour {

    public Image image;

    public void Start()
    {
        SetAlpha(0);
    }
    
    public void Flash()
    {
        SetAlpha(1);
    }

    public void Update()
    {
        float alpha = image.color.a;
        if (alpha > 0)
        {
            alpha -= 0.025f;
            if (alpha < 0) alpha = 0;
            SetAlpha(alpha);
        }
    }

    private void SetAlpha(float alpha)
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
    }


}
