using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour {

    public ScoreTextControl scoreText;
    public static int score;
    public static int hiScore;
    public static bool newRecord;
    private float timeAtStart;

    void Start()
    {
        score = 0;
        newRecord = false;
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
        if (score > hiScore)
        {
            hiScore = score;
            newRecord = true;
        }
        scoreText.SetScore(score);
    }

    public static int GetSeconds()
    {
        return score / 100;
    }

    public static int GetHundredths()
    {
        return score % 100;
    }

    public static bool IsNewRecord()
    {
        return newRecord;
    }

}
