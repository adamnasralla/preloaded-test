using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndMessageControl : MonoBehaviour {

    public Text scoreMessage;
    public Text recordMessage;

	// Use this for initialization
	void Start () 
    {
        scoreMessage.text = "You surfed for " + ScoreControl.GetSeconds() + ","
            + ScoreControl.GetHundredths().ToString("00") + " earth seconds";
        recordMessage.enabled = ScoreControl.IsNewRecord();
	}
	

}
