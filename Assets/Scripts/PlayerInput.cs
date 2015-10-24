using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

    public delegate void MoveAction();

    public static event MoveAction MoveRight;
    public static event MoveAction MoveLeft;

	void Update () 
    {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        if (MoveRight != null && horizontalAxis > 0) MoveRight();
        if (MoveLeft != null && horizontalAxis < 0) MoveLeft();
	}
}
