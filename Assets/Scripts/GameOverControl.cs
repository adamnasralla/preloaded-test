using UnityEngine;
using System.Collections;

public class GameOverControl : MonoBehaviour {

    public void GameOver()
    {
        Application.LoadLevel("End");
    }

}
