using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour {

    public ScoreTextControl scoreText;
    public static int score;
    public static int hiScore;
    private float timeAtStart;
    void Start()
    {
        score = 0;
        timeAtStart = Time.realtimeSinceStartup;
    }

    void Update()
    {
        int time = Mathf.RoundToInt((Time.realtimeSinceStartup-timeAtStart) * 10);
        setScore(time);
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
