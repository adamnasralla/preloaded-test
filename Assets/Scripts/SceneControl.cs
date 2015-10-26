using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour {

    private static bool isFirstTime = true;

	void Start () 
    {
        Time.timeScale = 1;
	}

    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            StartGame();
        }

    }

    public void StartGame()
    {
        if (isFirstTime)
        {
            GotoInfo();
        }
        else
        {
            Application.LoadLevel("Game");
        }
    }

    public void BackToMenu()
    {
        Application.LoadLevel("Start");
    }

    public void GotoInfo()
    {
        isFirstTime = false;
        Application.LoadLevel("Info");
    }
}
