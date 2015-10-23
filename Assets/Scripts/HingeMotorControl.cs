using UnityEngine;
using System.Collections;

public class HingeMotorControl : MonoBehaviour {

    private JointMotor motor;
    private HingeJoint hinge;

	void Start () 
    {
        hinge = GetComponent<HingeJoint>();
        motor = hinge.motor;
       // motor.targetVelocity = 0;
        hinge.motor = motor;
	}


    void SpinAntiClockwise()
    {
        motor.targetVelocity = 100f;
        hinge.motor = motor;
        hinge.useMotor = true;
    }

    void SpinClockwise()
    {
        motor.targetVelocity = -100f;
        hinge.motor = motor;
        hinge.useMotor = true;
    }

    //Setup Event Listeners
    void OnEnable()
    {
        
        PlayerInput.MoveRight += SpinAntiClockwise;
        PlayerInput.MoveLeft += SpinClockwise;
    }

    void OnDisable()
    {
        PlayerInput.MoveRight -= SpinAntiClockwise;
        PlayerInput.MoveLeft -= SpinClockwise;
    }
	
}
