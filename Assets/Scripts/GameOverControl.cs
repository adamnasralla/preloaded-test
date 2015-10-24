using UnityEngine;
using System.Collections;

public class GameOverControl : MonoBehaviour {

    public CollisionEventDispatcher eventDispatcher;

    void GameOver()
    {
        Application.LoadLevel(0);
    }

    void OnEnable()
    {
        eventDispatcher.WallHit += GameOver;
    }

    void OnDisable()
    {
        eventDispatcher.WallHit -= GameOver;
    }
}
