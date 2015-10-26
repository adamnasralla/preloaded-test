using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour {

    public SecondsTextControl secondsText;
    public SecondsTextControl recordText;
    public static int score;
    public static int hiScore;
    public static bool newRecord;
    private float timeAtStart;

    void Start()
    {
        Debug.Log("START");
        score = 0;
        newRecord = false;
        recordText.SetDisplay(hiScore);
        timeAtStart = Time.realtimeSinceStartup;
    }

    void Update()
    {
        int time = Mathf.RoundToInt((Time.realtimeSinceStartup-timeAtStart) * 100);
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
        secondsText.SetDisplay(score);
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
