using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour {

    public CollisionEventDispatcher eventDispatcher;
    public ScoreTextControl scoreText;
    private int score;


    void PickupCollected()
    {
        score += 50;
        scoreText.SetScore(score);
    }

    void OnEnable()
    {
        eventDispatcher.PickupCollected += PickupCollected;
    }

    void OnDisable()
    {
        eventDispatcher.PickupCollected -= PickupCollected;
    }
}
