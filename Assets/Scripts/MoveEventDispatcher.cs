using UnityEngine;
using System.Collections;

public class MoveEventDispatcher : MonoBehaviour {

    //TODO add stopMoveEvent
    public delegate void MoveAction();

    public event MoveAction MoveRight;
    public event MoveAction MoveLeft;

    public void FireMoveLeftEvent() 
    {
        if (MoveLeft != null)
        {
            MoveLeft();
        }
    }

    public void FireMoveRightEvent()
    {
        if (MoveRight != null)
        {
            MoveRight();
        }
    }
}
