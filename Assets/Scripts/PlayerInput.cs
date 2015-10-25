using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

    public MoveEventDispatcher moveEventDispatcher;

    void Start()
    {
        Time.timeScale = 1;
    }

	void Update () 
    {
        Time.timeScale += 0.0005f;
        Debug.Log(Time.timeScale);
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        if (horizontalAxis > 0) moveEventDispatcher.FireMoveRightEvent();
        if (horizontalAxis < 0) moveEventDispatcher.FireMoveLeftEvent();
	}
}
