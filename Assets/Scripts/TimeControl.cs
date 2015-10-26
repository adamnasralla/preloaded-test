using UnityEngine;
using System.Collections;

public class TimeControl : MonoBehaviour {

    public CollisionEventDispatcher eventDispatcher;
    public DisplayBarControl timeDisplay;
    private float deltaT;

	void Start () 
    {
        deltaT = 0.001f;
        Time.timeScale = 1;
	}
	
	void Update () 
    {
        Time.timeScale += deltaT;
        deltaT += 0.0000001f;
        Debug.Log(deltaT);
        timeDisplay.SetValue(Time.timeScale - 0.5f);
	}

    void SpeedUp()
    {
        Time.timeScale += 0.1f;
        timeDisplay.FlashUp();
    }

    void SpeedDown()
    {
        Time.timeScale -= Time.timeScale * 0.05f;
        timeDisplay.FlashDown();
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
