using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour {

	void Start () 
    {
        Time.timeScale = 1;
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
