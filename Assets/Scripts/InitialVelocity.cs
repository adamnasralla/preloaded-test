using UnityEngine;
using System.Collections;

public class InitialVelocity : MonoBehaviour {

    public Vector3 velocity;
    public Vector3 angularVelocity;

	void Start () 
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.angularVelocity = angularVelocity;
        rigidbody.velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
