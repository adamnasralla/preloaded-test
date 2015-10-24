using UnityEngine;
using System.Collections;

public class PlayerSetup : MonoBehaviour
{

    public SwingMovement swingMovement;

    void OnEnable()
    {

        PlayerInput.MoveRight += swingMovement.SwingRight;
        PlayerInput.MoveLeft += swingMovement.SwingLeft;
    }

    void OnDisable()
    {
        PlayerInput.MoveRight -= swingMovement.SwingRight;
        PlayerInput.MoveLeft -= swingMovement.SwingLeft;
    }

}
