using UnityEngine;
using System.Collections;

public class HingeMotorControl : MonoBehaviour {

    private JointMotor motor;
    private HingeJoint hinge;
    private Rigidbody rb;

	void Start () 
    {
        hinge = GetComponent<HingeJoint>();
        rb = GetComponent<Rigidbody>();
        motor = hinge.motor;
	}


    void SpinAntiClockwise()
    {
        if (rb.velocity == new Vector3(0, 0, 0))
        {
            rb.isKinematic = true;
            rb.isKinematic = false;
        }
        motor.targetVelocity = 100f;
        motor.freeSpin = false;
        motor.force = 200;
        hinge.motor = motor;
        hinge.useMotor = false;
    }

    void SpinClockwise()
    {
        if (rb.velocity == new Vector3(0, 0, 0))
        {
            rb.isKinematic = true;
            rb.isKinematic = false;
        }
        rb.AddForce(Vector3.zero);
        motor.targetVelocity = -100f;
        motor.freeSpin = false;
        motor.force = 200;
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
