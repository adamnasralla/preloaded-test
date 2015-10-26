using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SecondsTextControl : MonoBehaviour {

    public Text secondsText;

    public void SetDisplay(int centiseconds)
    {
        int seconds = centiseconds / 100;
        int hundreths = centiseconds % 100;
        secondsText.text = seconds.ToString("0000") + "' " 
            + hundreths.ToString("00") + "\"";
    }
}
