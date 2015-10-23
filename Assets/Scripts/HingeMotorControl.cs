using UnityEngine;
using System.Collections;

public class HingeMotorControl : MonoBehaviour {

    private JointMotor motor;
    private HingeJoint hinge;
    private Rigidbody rb;
    private bool didSpin = false;

	void Start () 
    {
        hinge = GetComponent<HingeJoint>();
        rb = GetComponent<Rigidbody>();
        motor = hinge.motor;
	}

    void Update()
    {
        if (!didSpin) hinge.useMotor = false;
        didSpin = false;
    }


    void SpinAntiClockwise()
    {

        if (rb.velocity == new Vector3(0, 0, 0))
        {
            rb.isKinematic = true;
            rb.isKinematic = false;
        }

        motor.targetVelocity = -1000f;
        

        if (hinge.useMotor)
        {
            if (hinge.angle < -81)
            {
                hinge.useMotor = false;
            }
        }
        else
        {
            if (hinge.angle > -80)
            {
                hinge.useMotor = true;
            }
        }
        
        if (hinge.angle > 81)
        {
            hinge.useMotor = false;
        }

        hinge.motor = motor;

        didSpin = true;
    }

    void SpinClockwise()
    {

        Debug.Log("Clock");
        if (rb.velocity == new Vector3(0, 0, 0))
        {
            rb.isKinematic = true;
            rb.isKinematic = false;
        }
        motor.targetVelocity = 1000f;
        
        if (hinge.useMotor)
        {
            if (hinge.angle > 81)
            {
                hinge.useMotor = false;
            }
        }
        else
        {
            if (hinge.angle < 80)
            {
                hinge.useMotor = true;
            }
        }
        
        if (hinge.angle < -81)
        {
            hinge.useMotor = false;
        }


        hinge.motor = motor;
        didSpin = true;
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
