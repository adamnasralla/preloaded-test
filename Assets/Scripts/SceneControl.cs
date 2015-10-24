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
        Application.LoadLevel(1);
    }

    public void BackToMenu()
    {
        Application.LoadLevel(0);
    }
}
