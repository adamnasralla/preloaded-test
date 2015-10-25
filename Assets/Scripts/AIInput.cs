using UnityEngine;
using System.Collections;

public class AIInput : MonoBehaviour {

    public MoveEventDispatcher moveEventDispatcher;

    private int currentDirection = 0;

    void FixedUpdate()
    {
        
        if (Random.Range(0, 1.0f) < 0.02f) changeDirection();

        if (currentDirection == 1) moveEventDispatcher.FireMoveRightEvent();
        if (currentDirection == 2) moveEventDispatcher.FireMoveLeftEvent();
    }

    void changeDirection()
    {
        currentDirection = Random.Range(0, 3);
    }
}
