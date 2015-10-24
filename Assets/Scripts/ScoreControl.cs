using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour {

    public CollisionEventDispatcher eventDispatcher;
    public ScoreTextControl scoreText;
    public static int score;
    public static int hiScore;


    void PickupCollected()
    {
        score += 50;
        scoreText.SetScore(score);
    }

    public void addScore(int scoreToAdd)
    {
        setScore(score + scoreToAdd);
    }

    public void setScore(int newScore)
    {
        score = newScore;
        if (score > hiScore) hiScore = score;
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
