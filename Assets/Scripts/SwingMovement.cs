using UnityEngine;
using System.Collections;

public class SwingMovement : MonoBehaviour{

    private bool hasMoved = false;

    private const float TARGET_VELOCITY = 1000f;
    private const float SWING_ANGLE_RANGE_IF_OFF = 80;
    private const float SWING_ANGLE_RANGE_IF_ON = 81; 

    public HingeMotorControl motor;

	void Update () 
    {
        if (!hasMoved) StopSwinging();
        hasMoved = false;
	}

    public void SwingLeft()
    {
        if (IsInSwingRange())
        {
            motor.SetTargetVelocity(TARGET_VELOCITY);
            hasMoved = true;
        }
    }

    public void SwingRight()
    {
        if (IsInSwingRange())
        {
            motor.SetTargetVelocity(-TARGET_VELOCITY);
            hasMoved = true;
        }
    }

    void StopSwinging()
    {
        motor.SetIsOn(false);
    }

    //margin between range if engine is previous on or off allows swinger to sway slightly at extremities
    bool IsInSwingRange()
    {
        float angle = motor.GetAngle();
        if (motor.GetIsOn())
        {
            if (angle > -SWING_ANGLE_RANGE_IF_ON && angle < SWING_ANGLE_RANGE_IF_ON)
            {
                return true;
            }
        }
        else
        {
            if (angle > -SWING_ANGLE_RANGE_IF_OFF && angle < SWING_ANGLE_RANGE_IF_OFF)
            {
                return true;
            }
        }
        return false;
    }


}
