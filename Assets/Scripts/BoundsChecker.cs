using UnityEngine;
using System.Collections;

public class BoundsChecker : MonoBehaviour {

	private float checkDelay = 0.5f;
    public float Z_MIN = 0;


	void Start () 
    {
	    StartCoroutine(CheckOutOfBounds());
	}
	
	IEnumerator CheckOutOfBounds()
    {
        while (true)
        {
            if (IsOutOfBounds()) Destroy(gameObject);
            yield return new WaitForSeconds(checkDelay);
        }
        
    }

    bool IsOutOfBounds()
    {
        return (gameObject.transform.position.z < Z_MIN);
    }
}
