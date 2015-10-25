using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour {

    public ScoreTextControl scoreText;
    public static int score;
    public static int hiScore;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        addScore(1);
    }

    public void addScore(int scoreToAdd)
    {
        setScore(score + scoreToAdd);
    }

    public void setScore(int newScore)
    {
        score = newScore;
        if (score > hiScore) hiScore = score;
        scoreText.SetScore(score);
    }

}
