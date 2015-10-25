using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame()
    {
        Application.LoadLevel("Game");
    }

    public void BackToMenu()
    {
        Application.LoadLevel("Start");
    }

    public void GotoInfo()
    {
        Application.LoadLevel("Info");
    }
}
