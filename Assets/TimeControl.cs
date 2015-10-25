using UnityEngine;
using System.Collections;

public class TimeControl : MonoBehaviour {

    public CollisionEventDispatcher eventDispatcher;
    public ScoreTextControl timeText;

	void Start () 
    {
        Time.timeScale = 1;
	}
	
	void Update () 
    {
        Time.timeScale += 0.00075f;
        int timeS = Mathf.RoundToInt(Time.timeScale * 100f);
        timeText.SetScore(timeS);
	}

    void SpeedUp()
    {
        Time.timeScale += 0.1f;
    }

    void SpeedDown()
    {
        Time.timeScale -= 0.05f;
    }

    void OnEnable()
    {
        eventDispatcher.SpinUpCollected += SpeedUp;
        eventDispatcher.SpinDownCollected += SpeedDown;
    }

    void OnDisable()
    {
        eventDispatcher.SpinUpCollected -= SpeedUp;
        eventDispatcher.SpinDownCollected -= SpeedDown;
    }
}
