using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

    public MoveEventDispatcher moveEventDispatcher;

	void Update () 
    {
        Time.timeScale += 0.0003f;
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        if (horizontalAxis > 0) moveEventDispatcher.FireMoveRightEvent();
        if (horizontalAxis < 0) moveEventDispatcher.FireMoveLeftEvent();
	}
}
