using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndMessageControl : MonoBehaviour {

    public SecondsTextControl secondsText;
    public Text recordMessage;

	// Use this for initialization
	void Start () 
    {
        secondsText.SetDisplay(ScoreControl.score);
        recordMessage.enabled = ScoreControl.IsNewRecord();
	}
	

}
