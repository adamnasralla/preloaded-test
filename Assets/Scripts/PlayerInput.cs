using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

    public delegate void MoveAction();
    public static event MoveAction MoveRight;
    public static event MoveAction MoveLeft;

	
	// Update is called once per frame
	void Update () 
    {
        if (MoveRight != null && Input.GetAxis("Horizontal") > 0) MoveRight();
        if (MoveLeft != null && Input.GetAxis("Horizontal") < 0) MoveLeft();
	}
}
