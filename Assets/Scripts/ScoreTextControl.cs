using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTextControl : MonoBehaviour
{
    public Text scoreText;
    public string zeroString;
    public string prefix;

    public void SetScore(int score)
    {
        scoreText.text = prefix + score.ToString(zeroString);
    }

}