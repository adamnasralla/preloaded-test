using UnityEngine;
using System.Collections;

public class ObjectSpinner : MonoBehaviour {

    public float xSpin;
    public float ySpin;
    public float zSpin;

	void Start () 
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.angularVelocity = new Vector3(xSpin, ySpin, zSpin);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
