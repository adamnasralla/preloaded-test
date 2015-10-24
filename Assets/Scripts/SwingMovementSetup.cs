using UnityEngine;
using System.Collections;

public class SwingMovementSetup : MonoBehaviour
{

    public SwingMovement swingMovement;
    public MoveEventDispatcher moveEventDispatcher;

    void OnEnable()
    {
        moveEventDispatcher.MoveRight += swingMovement.SwingRight;
        moveEventDispatcher.MoveLeft += swingMovement.SwingLeft;
    }

    void OnDisable()
    {
        moveEventDispatcher.MoveRight -= swingMovement.SwingRight;
        moveEventDispatcher.MoveLeft -= swingMovement.SwingLeft;
    }

}
