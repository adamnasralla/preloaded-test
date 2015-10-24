using UnityEngine;
using System.Collections;

public class PickupControl : MonoBehaviour {

    PickupEventDispatcher eventDispatcher;

	void Start () 
    {
        GameObject gameControl = GameObject.FindGameObjectWithTag("GameController");
        eventDispatcher = gameControl.GetComponent<PickupEventDispatcher>();
	}
	
	void OnTriggerEnter(Collider collider)
    {
        eventDispatcher.FirePickupCollectedEvent();
        Destroy(gameObject);
    }
}
