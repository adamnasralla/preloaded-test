using UnityEngine;
using System.Collections;

public class HingeMotorControl : MonoBehaviour {

    private JointMotor motor;
    private HingeJoint hinge;
    private Rigidbody rigidbody;

	void Awake () 
    {
        hinge = GetComponent<HingeJoint>();
        rigidbody = GetComponent<Rigidbody>();
        motor = hinge.motor;
	}

    public void SetTargetVelocity(float targetVelocity)
    {
        RefreshStationaryRigidbody();
        FixNegativeVelocityBug(targetVelocity);

        hinge.useMotor = true;
        hinge.motor = motor;
    }



    public void SetIsOn(bool isOn)
    {
        RefreshStationaryRigidbody();
        hinge.useMotor = isOn;
    }

    public float GetAngle()
    {
        return hinge.angle;
    }

    public bool GetIsOn()
    {
        return hinge.useMotor;
    }


    //Fixes a Unity Engine bug where hinge motor does not respond if rigidbody is stationary!
    private void RefreshStationaryRigidbody()
    {
        if (rigidbody.velocity == new Vector3(0, 0, 0))
        {
            rigidbody.isKinematic = true;
            rigidbody.isKinematic = false;
        }
    }

    //Unity update does not allow negative values in motor z axis must be flipped
    public void FixNegativeVelocityBug(float targetVelocity)
    {
        if (targetVelocity < 0)
        {
            targetVelocity *= -1;
            hinge.axis = new Vector3(0, 0, 1);
        }
        else if (targetVelocity > 0)
        {
            hinge.axis = new Vector3(0, 0, -1);
        }
        motor.targetVelocity = targetVelocity;
    }


}
